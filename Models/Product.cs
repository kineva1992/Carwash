using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Carwash.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        //Название услуги
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage ="Введите название услуги")]
        public string ProductName { get; set; }

        //Описание услуги
        public string Discriptio { get; set; }

        //Дата создание
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        //Дата изменения
        [DataType(DataType.Date)]
        public DateTime? EditDate { get; set; }

        //Цена услуги необходимо добавить в таблицу ClassCars и сделать связь Product-one-Many-ClassCars
        [DataType(DataType.Currency)]
        public decimal? Price{ get; set; }

        public IEnumerable<ClassAuto> ClassAutos { get; set; }


    }
}
