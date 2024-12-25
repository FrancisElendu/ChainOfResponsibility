using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Core.Repositories
{
    public interface IRepository<CourseEnrollment>
    {
        Task AddAsync(CourseEnrollment entity);
    }
}
