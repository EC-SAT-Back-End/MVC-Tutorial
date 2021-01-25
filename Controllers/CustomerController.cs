using MVC_Tutoriall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutoriall.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult DisplayCustomer()
        {
            var customer = new Customer(100, "ahmed", "cairo", 32);

            return View(customer);
        }
        public ActionResult Create()
        {
            var cust = new Customer();
            return View(cust);
        }
    }
}