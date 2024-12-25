using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.Application.Services;
using StudentPortal.Core.Entities;


namespace StudentPortal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly CourseEnrollmentService _courseEnrollmentService;

        // Constructor injection of CourseEnrollmentService
        public EnrollmentController(CourseEnrollmentService courseEnrollmentService)
        {
            _courseEnrollmentService = courseEnrollmentService;
        }

        /// <summary>
        /// Enrolls a student in a course.
        /// </summary>
        /// <param name="studentId">The ID of the student.</param>
        /// <param name="courseId">The ID of the course.</param>
        /// <returns>Action result indicating the status of enrollment.</returns>
        [HttpPost("enroll")]
        //public IActionResult EnrollStudent(int studentId, int courseId)
        public IActionResult EnrollStudent(CourseEnrollmentRequest request)
        {
            try
            {
                //_courseEnrollmentService.EnrollStudent(studentId, courseId);
                _courseEnrollmentService.EnrollStudent(request);
                //return Ok($"Student {studentId} has been successfully enrolled in course {courseId}.");
                return Ok($"Student {request.StudentId} has been successfully enrolled in course {request.CourseId}.");
            }
            catch (Exception ex)
            {
                // Handle errors and return a meaningful response
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }
    }
}
