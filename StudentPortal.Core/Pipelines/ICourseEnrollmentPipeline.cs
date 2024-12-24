using StudentPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Core.Pipelines
{
    public interface ICourseEnrollmentPipeline
    {
        void Process(CourseEnrollmentRequest request);
    }
}
