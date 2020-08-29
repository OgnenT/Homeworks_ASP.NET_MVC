using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.CLASS_02.Controlers.Models
{
    public enum PizzaSize { small, medium, large }
    public class PizzaModel
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public PizzaSize Size { get; set; }
    }
}
