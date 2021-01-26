using MVC_Tutoriall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutoriall.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee {ID = 1 , Name = "a",Addrees = "cai", Sallery= 500},
            new Employee {ID = 2 , Name = "b",Addrees = "alex", Sallery= 600},
            new Employee {ID = 3 , Name = "c",Addrees = "asm", Sallery= 700},
            new Employee {ID = 4 , Name = "d",Addrees = "cbv", Sallery= 800},

        };
        // GET: Employee
        public ActionResult Index()
        {

            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
