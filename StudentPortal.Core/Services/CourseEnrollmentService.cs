using StudentPortal.Core.Entities;
using StudentPortal.Core.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Core.Services
{
    public class CourseEnrollmentService
    {
        private readonly ICourseEnrollmentPipeline _pipeline;
        public CourseEnrollmentService(ICourseEnrollmentPipeline pipeline)
        {
            _pipeline = pipeline;
        }

        public void EnrollStudent(int studentId, int courseId)
        {
            var request = new CourseEnrollmentRequest
            {
                StudentId = studentId,
                CourseId = courseId
            };

            _pipeline.Process(request);
        }

    }
}
