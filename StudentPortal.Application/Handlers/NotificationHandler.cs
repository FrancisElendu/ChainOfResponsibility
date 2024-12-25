using StudentPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Application.Handlers
{
    public class NotificationHandler : RequestHandlerBase
    {
        public override void Handle(CourseEnrollmentRequest request)
        {
            // Simulate sending notification
            if (request.IsGradeAssigned)
            {
                Console.WriteLine($"Notification sent to student {request.StudentId} about course {request.CourseId} enrollment and grade assignment.");
            }
            base.Handle(request);
        }

    }
}
