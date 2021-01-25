using MVC_Tutoriall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutoriall.Controllers
{
    public class ComputerController : Controller
    {
        // GET: Computer
        public ActionResult Display()
        {
            var myComputer = new Computer
            {
                ID = 1,
                Name = "apple",
                Price = 101.20
            };
            return View(myComputer);
        }

    }
}