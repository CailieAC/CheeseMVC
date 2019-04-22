using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2 ()
        {
            //This will render the Index view above
            return View("Index");
        }
    }
}