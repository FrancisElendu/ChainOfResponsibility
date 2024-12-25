using StudentPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Application.Handlers
{
    public interface IRequestHandler
    {
        IRequestHandler SetNext(IRequestHandler next);
        void Handle(CourseEnrollmentRequest request);

    }
}
