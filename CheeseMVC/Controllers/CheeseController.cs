using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        //static means this property is available to any code in the class
        //static private List<string> Cheeses = new List<string>();
        //static private List<Cheese> Cheeses = new List<Cheese>();

        public IActionResult Index()
        {
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(Cheese newCheese)
        {
            //Add the new cheese to my existing cheeses 
            /*Model binding means we don't have to create a new cheese like this. But you have to
             * have a default constructor in the model for model binding to work
             * Cheese newCheese = new Cheese
            {
                Description = description,
                Name = name
            };
            */

            CheeseData.Add(newCheese);

            /*Another way:
            Cheese newCheese = new Cheese();
            newCheese.Description = description;
            newCheese.Name = name;
            */

            return RedirectToAction(actionName: nameof(Index));
        }

        /*
        public IActionResult Index2 ()
        {
            //This will render the Index view above
            return View("Index");
        }
        */

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Cheeses";
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] cheeseIds)
        {
            foreach (int cheeseId in cheeseIds)
            {
                CheeseData.Remove(cheeseId);
            }
            return Redirect("/Cheese");
        }
    }
}