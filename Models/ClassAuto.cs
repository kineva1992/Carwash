using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carwash.Models;

namespace Carwash.Models
{
    public class ClassAuto
    {
        public int ClassAutoID { get; set; }
        public string NameAuto { get; set; }
        public string ClassAutos { get; set; }
        public Product ProductID { get; set; }
    }
}
