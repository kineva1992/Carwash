using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carwash.Models
{
    public class NewsModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Введите название новости")]
        [Display(Name = "Название новости")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Введите короткое описание текста новости")]
        public string SomeText { get; set; }

        [Required(ErrorMessage ="Введите текст новости")]
        public string Text { set; get; }
        public string Author { set; get; }
        [DataType(DataType.Date)]
        public DateTime CreateNews { set; get; }

        [DataType(DataType.Date)]
        public DateTime EditNews { set; get; }

    }
}
