using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Tutoriall.Controllers
{
    [RoutePrefix("Cars")]
    public class CarController : Controller
    {
        // GET: Car
        [Route("Index")]
        public ContentResult Index()
        {
            return Content("<h1> From content Resault</h1>");
        }
        public ActionResult RenderBody()
        {
            return View();
        }
        [Route("Details/{id:int}")]
        public ContentResult Details(int id)
        {
            return Content("<h2> Car ID :" +  id +"</h2>");
        }
    }
}