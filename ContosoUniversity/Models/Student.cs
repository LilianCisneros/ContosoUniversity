using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { set; get; }

        [StringLength(50)]
        public string LastName { set; get; }

        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstMidName { set; get; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { set; get; }
        public string Secret { get; set; }
        public virtual ICollection<Enrollment> Enrollments { set; get; }
    }
}