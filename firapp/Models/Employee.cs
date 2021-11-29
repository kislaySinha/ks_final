using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace firapp.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "please enter your name")]
        public string Name { get; set; }
        [Range(16, 60, ErrorMessage = "Ages 16-60 only")]
        public int Age { get; set; }
        [Required(ErrorMessage = "please select your salary")]
        public decimal Salary { get; set; }
        
        public string Department { get; set; }
        [RegularExpression(@"^[MF]+$",ErrorMessage = "please select one option")]
        public Char Sex { get; set; }
    }
}
