using StudentPortal.Core.Entities;

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
