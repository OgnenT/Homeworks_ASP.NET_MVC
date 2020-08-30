using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.CLASS_02.Controlers.Models;

namespace SEDC.CLASS_02.Controlers.Controllers
{
    [Route("pizzas")]
    public class PizzaController : Controller
    {
        [Route("start")]
        public IActionResult Index()
        {
            var pizza = PizzaDb.Pizza;
            return View(pizza);
        }

        [HttpGet]
        [Route("details/{id:int}")]
        public IActionResult PizzaDetails(int id)
        {
            PizzaModel pizz = PizzaDb.Pizza.SingleOrDefault(p => p.Id == id);
            return View(pizz);
        }

        [HttpGet]
        [Route("createPizzaForm")]
        public IActionResult CreatePizza()
        {
            return View();
        }

        [HttpPost]
        [Route("createPizzaForm")]
        public IActionResult CreatePizza(PizzaModel insertPizza)
        {
            PizzaModel pizza = new PizzaModel()
            {
                Id = PizzaDb.Pizza.Count + 1,
                PizzaName = insertPizza.PizzaName,
                Size = insertPizza.Size
            };
            PizzaDb.Pizza.Add(pizza);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id:int}")]
        public IActionResult DeletePizza(int id)
        {
            PizzaModel models = PizzaDb.Pizza.FirstOrDefault(p => p.Id == id);
            return View(models);
        }

        [HttpPost]
        [Route("delete/{id:int}")]
        public IActionResult DeletePizzaById(int id)
        {
            PizzaModel delete = PizzaDb.Pizza.FirstOrDefault(p => p.Id == id);
            PizzaDb.Pizza.Remove(delete);

            return RedirectToAction("Index");
        }
    }
}
