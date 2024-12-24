using StudentPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Core.Handlers
{
    public class GradeAssignmentHandler : RequestHandlerBase
    {
        public override void Handle(CourseEnrollmentRequest request)
        {
            // Simulate grade assignment
            if (request.Status == "Enrolled")
            {
                request.IsGradeAssigned = true;
                Console.WriteLine($"Grade assigned to student {request.StudentId} for course {request.CourseId}.");
            }
            base.Handle(request);
        }

    }
}
