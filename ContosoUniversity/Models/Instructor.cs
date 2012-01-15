using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Instructor
    {
        public Int32 InstructorID { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        [MaxLength(50)]
        public string FirstMidName { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Hire date is required.")]
        [Display(Name = "Hire Date")]
        public DateTime? HireDate { get; set; }

        // Calculated property. Only a get accessor, and no FullName column will be generated in the database.
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        // Courses and OfficeAssignment properties are navigation properties. 
        // Defined as virtual so that they can take advantage of lazy loading. 
        // If a navigation property can hold multiple entities, its type must be ICollection.
        public virtual ICollection<Course> Courses { get; set; }
        public virtual OfficeAssignment OfficeAssignment { get; set; }
    }
}