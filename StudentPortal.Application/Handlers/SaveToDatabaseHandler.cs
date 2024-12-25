using StudentPortal.Core.Entities;
using StudentPortal.Core.Repositories;

namespace StudentPortal.Application.Handlers
{
    public class SaveToDatabaseHandler : RequestHandlerBase
    {
        private readonly IRepository<CourseEnrollment> _repo;

        public SaveToDatabaseHandler(IRepository<CourseEnrollment> repo)
        {
            _repo = repo;
        }

        public override void Handle(CourseEnrollmentRequest request)
        {
            // Save to database
            var enrollment = new CourseEnrollment
            {
                StudentId = request.StudentId,
                CourseId = request.CourseId,
                Status = request.Status,
                EnrolledOn = DateTime.UtcNow
            };


            _repo.AddAsync(enrollment);
            //_dbContext.CourseEnrollments.Add(enrollment);
            //_dbContext.SaveChanges();

            Console.WriteLine($"Student {request.StudentId} enrollment saved to database.");

            // Call the next handler in the chain
            base.Handle(request);
        }
    }
}
