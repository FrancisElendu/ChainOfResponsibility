﻿using Microsoft.Extensions.DependencyInjection;
using StudentPortal.Core.Handlers;
using StudentPortal.Core.Pipelines;
using StudentPortal.Core.Services;

namespace StudentPortal.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds all core services, handlers, and pipelines to the DI container.
        /// </summary>
        /// <param name="services">The service collection to register dependencies.</param>
        /// <returns>The modified service collection.</returns>
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            // Register handlers
            services.AddTransient<IRequestHandler, CourseEnrollmentHandler>();
            services.AddTransient<IRequestHandler, GradeAssignmentHandler>();
            services.AddTransient<IRequestHandler, NotificationHandler>();

            // Register pipelines
            services.AddTransient<ICourseEnrollmentPipeline, CourseEnrollmentPipeline>();

            // Register services
            services.AddTransient<CourseEnrollmentService>();

            return services;
        }
    }
}