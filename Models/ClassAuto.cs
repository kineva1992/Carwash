using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Carwash.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Carwash.Models
{
    public class ClassAuto
    {
        public int ClassAutoID { get; set; }


        [Display(Name = "Название атомобиля")]
        public string NameAuto { get; set; }

        [Display(Name = "Класс автомобиля")]
        public string ClassAutos { get; set; }

        // 2 метода для связи
        [Display(Name ="Выберити категорю для мойки автомобиля")]
        public int ProductID { get; set; }

        public Product Product { get; set; }


      
    }
}
