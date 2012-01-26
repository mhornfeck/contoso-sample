using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        // set MaxLength to avoid having EF create varchar(max) columns in db tables
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        [MaxLength(50)]
        public string FirstMidName { get; set; }

        // Calculated property. Only a get accessor, and no FullName column will be generated in the database.
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
    }
}