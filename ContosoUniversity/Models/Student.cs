using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { set; get; }
        public string LastName { set; get; }
        public string FirstMidName { set; get; }
        public DateTime EnrollmentDate { set; get; }
        public string Secret { get; set; }
        public virtual ICollection<Enrollment> Enrollments { set; get; }
    }
}