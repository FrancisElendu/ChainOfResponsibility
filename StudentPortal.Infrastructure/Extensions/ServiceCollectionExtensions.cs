using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentPortal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Core.Repositories;
using StudentPortal.Core.Entities;
using StudentPortal.Infrastructure.Repositories;

namespace StudentPortal.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<StudentPortalDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
                    .EnableSensitiveDataLogging());

            //services.AddScoped<IDatabaseSeeder, DatabaseSeeder>();
            services.AddScoped<IRepository<CourseEnrollment>, Repository<CourseEnrollment>>();
        }
    }
}
