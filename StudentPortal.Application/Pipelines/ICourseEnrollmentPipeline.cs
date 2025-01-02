using StudentPortal.Core.Entities;

namespace StudentPortal.Application.Pipelines
{
    public interface ICourseEnrollmentPipeline
    {
        void Process(CourseEnrollmentRequest request);
    }
}
