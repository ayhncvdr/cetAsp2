using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cetAsp2.Models
{
    public class Student
    {
        public Student()
        {
            
            
            

            
        }
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter a name!")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a surname!")]
        public string Surname { get; set; }

        public string Department { get; set; }

        [Required(ErrorMessage = "Please enter a birth date!")]

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }

        public DateTime CreationDate { get; set; }

        
        public DateTime LastUpdateDate { get; set; }
        public int Age { get ; set; }







    }
}
