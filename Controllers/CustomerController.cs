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
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                RedirectToAction("DisplayCustomer");

            }
            return View(customer);
        }
        public ActionResult Search()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Search(string name)
        {
            List<Customer> customers = new List<Customer>() {
                new Customer {ID= 1 ,Name ="mohamed",Address ="alex",Age=10},
                new Customer {ID= 1 ,Name ="hamza",Address ="alex",Age=10},
                new Customer {ID= 1 ,Name ="mostafa",Address ="por",Age=10},
                new Customer {ID= 1 ,Name ="mero",Address ="baleh",Age=10},
            };
            var cust = customers.Find(a => a.Name == name);
            if (cust!= null)
            {
                ViewBag.Result = "Result is :" + cust ;
                ViewData["State"] = true;
            }
            else
            {
                ViewBag.Result = "Result is not found :" + cust;
                ViewData["State"] = false;

            }
            return View(cust);

        }
    }
}