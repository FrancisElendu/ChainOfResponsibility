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

            //to implement graceful error handling across the chain
            try
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

                Console.WriteLine($"Student {request.StudentId} enrollment saved to database.");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error in {this.GetType().Name}: {ex.Message}");
            }
            finally
            {
                // Call the next handler in the chain
                base.Handle(request);
            }
            //// Save to database
            //var enrollment = new CourseEnrollment
            //{
            //    StudentId = request.StudentId,
            //    CourseId = request.CourseId,
            //    Status = request.Status,
            //    EnrolledOn = DateTime.UtcNow
            //};


            //_repo.AddAsync(enrollment);

            //Console.WriteLine($"Student {request.StudentId} enrollment saved to database.");

            //// Call the next handler in the chain
            //base.Handle(request);
        }
    }
}
