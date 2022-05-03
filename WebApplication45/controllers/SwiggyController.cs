using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication45.Model;

namespace WebApplication45.controllers
{
    public class SwiggyController : Controller
    {
        // GET: Swiggy
        ApplicationDbContext applicationDb = new ApplicationDbContext();
        public ActionResult Index()
        {
            List<employee> employees = applicationDb.employees.ToList();

            return View(employees);
        }
    }
}