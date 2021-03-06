﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.CLASS_02.Controlers.Models
{
    public enum PizzaSize { Small, Medium, Large }
    public class PizzaModel
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public PizzaSize Size { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
