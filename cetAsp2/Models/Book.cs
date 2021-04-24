using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cetAsp2.Models
{
    public class Book
    {
        public Book()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }

        [DisplayName("İsim")]
        [Required(ErrorMessage ="Lütfen isim giriniz!")]
        public string Name { get; set; }
        public string Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        public int? PageCount { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }


    }
}
