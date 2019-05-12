using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WebAppEF.Model.Entity
{
    public class Student
    {
        [DisplayName("Student ID")]
        public int ID { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("First Name")]
        public string FirstMidName { get; set; }

        [DisplayName("Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
