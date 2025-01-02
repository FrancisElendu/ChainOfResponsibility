using Microsoft.Extensions.DependencyInjection;
using StudentPortal.Application.GenericHandlers;
using StudentPortal.Application.Handlers;
using StudentPortal.Application.Pipelines;
using StudentPortal.Application.Services;
using StudentPortal.Core.Entities.Interfaces;
using StudentPortal.Core.GenericRepositories;
using StudentPortal.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentPortal.Application.Extensions
{
    public static class HandlerRegistrationExtensions
    {
        public static IServiceCollection AddGenericHandlers<TRequest, TEntity>(
            this IServiceCollection services,
            Func<TRequest, bool> shouldNotify,
            Action<TRequest> notify)
            where TRequest : class, IRequest<TEntity>
        {
            // Register NotificationHandler
            services.AddTransient<IHandler<TRequest>>(sp =>
            {
                var notificationHandler = new NotificationHandler<TRequest>(shouldNotify, notify);

                // Resolve and register next handler (SaveToDatabaseHandler)
                var repository = sp.GetRequiredService<Core.GenericRepositories.IRepository<TEntity>>();
                var saveToDatabaseHandler = new SaveToDatabaseHandler<TRequest, TEntity>(repository);

                // Chain handlers
                notificationHandler.SetNext(saveToDatabaseHandler);

                return notificationHandler;
            });

            return services;
        }
    }
}
