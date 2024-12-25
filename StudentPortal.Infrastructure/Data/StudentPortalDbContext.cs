using Microsoft.EntityFrameworkCore;
using StudentPortal.Core.Entities;

namespace StudentPortal.Infrastructure.Data
{
    public class StudentPortalDbContext : DbContext
    {
        public StudentPortalDbContext(DbContextOptions<StudentPortalDbContext> options) : base(options) { }

        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
    }
}
