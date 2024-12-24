using StudentPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Core.Handlers
{
    public class CourseEnrollmentHandler : RequestHandlerBase
    {
        public override void Handle(CourseEnrollmentRequest request)
        {
            // Simulate course enrollment
            request.Status = "Enrolled";
            Console.WriteLine($"Student {request.StudentId} enrolled in course {request.CourseId}.");
            base.Handle(request);
        }

    }
}
