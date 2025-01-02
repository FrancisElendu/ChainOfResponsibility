using StudentPortal.Core.Repositories;
using StudentPortal.Infrastructure.Data;

namespace StudentPortal.Infrastructure.Repositories
{
    public class Repository<CourseEnrollment> : IRepository<CourseEnrollment>
    {
        private readonly StudentPortalDbContext _context;
        public Repository(StudentPortalDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(CourseEnrollment entity)
        {
            await _context.AddAsync(entity);
            _context.SaveChanges();
        }
    }
}
