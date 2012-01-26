using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Department name is required.")]
        [MaxLength(50)]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [Required(ErrorMessage = "Budget is required.")]
        [Column(TypeName = "money")]
        public decimal? Budget { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Start date is required.")]
        public DateTime StartDate { get; set; }

        // A department may or may not have an administrator, and an administrator is always an instructor. 
        // Therefore the FullName property is included as the foreign key to the Instructor entity, 
        // and a question mark is added after the int type designation to mark the property as nullable. 
        // The navigation property is named Administrator but holds an Instructor entity.

        [Display(Name = "Administrator")]
        public int? PersonID { get; set; }

        // The Timestamp attribute specifies that this column will be included in the Where 
        // clause of Update and Delete commands sent to the database.
        [Timestamp]
        public Byte[] Timestamp { get; set; }

        // By convention, the Entity Framework enables cascade delete for non-nullable foreign keys and 
        // for many-to-many relationships.

        public virtual Instructor Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}