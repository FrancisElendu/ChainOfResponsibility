using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Core.Entities
{
    public class CourseEnrollmentRequest
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string Status { get; set; }
        public bool IsGradeAssigned { get; set; }

    }
}
