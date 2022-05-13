using MVC_Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Dashboard.Controllers
{
    public class EmployeeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        // GET: Employee
        public ActionResult Index()
        {
            ViewBag.Employees = db.Employees;
            return View();
        }

        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
