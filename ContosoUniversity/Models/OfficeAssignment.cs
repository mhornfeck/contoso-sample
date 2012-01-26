using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        // An office assignment only exists in relation to the instructor it's assigned to, and therefore 
        // its primary key is also its foreign key to the Instructor entity.
        [Key]
        public int PersonID { get; set; }

        [MaxLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}