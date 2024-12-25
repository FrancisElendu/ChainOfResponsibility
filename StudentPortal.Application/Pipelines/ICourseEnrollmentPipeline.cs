using StudentPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Application.Pipelines
{
    public interface ICourseEnrollmentPipeline
    {
        void Process(CourseEnrollmentRequest request);
    }
}
