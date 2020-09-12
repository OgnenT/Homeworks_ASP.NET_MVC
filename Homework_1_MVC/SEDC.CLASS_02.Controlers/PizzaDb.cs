using SEDC.CLASS_02.Controlers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.CLASS_02.Controlers
{
    public static class PizzaDb
    {
        public static List<PizzaModel> Pizza;
        static PizzaDb()
        {
            Pizza = new List<PizzaModel>()
            {
                new PizzaModel(){ Id = 1, PizzaName = "Capricciosa", Size = PizzaSize.Small, Ingredients = { "garlic","mushrooms"} },
                new PizzaModel(){ Id = 2, PizzaName = "Siciliana", Size = PizzaSize.Medium, Ingredients = { "cheese","paprika"}  },
                new PizzaModel(){ Id = 3, PizzaName = "Calzone", Size = PizzaSize.Large, Ingredients = { "tomato","bacon"}  }
            };
        }
    }
}
