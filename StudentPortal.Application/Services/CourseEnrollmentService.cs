using StudentPortal.Core.Entities;
using StudentPortal.Application.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Application.Services
{
    public class CourseEnrollmentService
    {
        private readonly ICourseEnrollmentPipeline _pipeline;
        public CourseEnrollmentService(ICourseEnrollmentPipeline pipeline)
        {
            _pipeline = pipeline;
        }

        //public void EnrollStudent(int studentId, int courseId)
        public void EnrollStudent(CourseEnrollmentRequest request)
        {
            //var request = new CourseEnrollmentRequest
            //{
            //    StudentId = studentId,
            //    CourseId = courseId,
            //    //IsGradeAssigned = true
            //};

            _pipeline.Process(request);
        }

    }
}
