using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace School.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Display(Name = "Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }
        
        
        [Url]
        [Display(Name = "Blog Url")]
        public string BlogUrl { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        
        [Phone]
        public string Mobile { get; set; }
        
        [RegularExpression(".{6,}",ErrorMessage ="Password should be more than 6 char")]
        [DataType(DataType.Password)]
        public string Passowrd { get; set; }
        
        [Display(Name = "National Code")]
        [RegularExpression("[0-9]{14}")]
        [Required]
        public string NationalId { get; set; }

        [Range(500, 10000)]
        [DataType(DataType.Currency)]
        public double? Salary { get; set; }

        public bool? ismarried { get; set; }
      
    }
}