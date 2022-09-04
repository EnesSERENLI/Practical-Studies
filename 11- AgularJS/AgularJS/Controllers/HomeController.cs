using AgularJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgularJS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        List<Employee> employees = new List<Employee>()
        {
            new Employee{FirstName = "Enes",LastName = "Serenli",Age = 29, MaleOrFemale = "E",CityId =1,TownId =1,Address = "H.mah F.cad. No:18 D:8"},
            new Employee{FirstName = "Semih",LastName = "Serenli",Age = 33, MaleOrFemale = "E",CityId =1,TownId =1,Address = "H.mah F.cad. No:18 D:8"},
            new Employee{FirstName = "Fatih",LastName = "Serenli",Age = 20, MaleOrFemale = "E",CityId =1,TownId =1,Address = "H.mah F.cad. No:18 D:8"},
        };

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Employees()
        {
            var result = new JsonResult { Data = employees, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            return result;
        }

        public ActionResult GetEmployees()
        {
            var result = Employees();
            return View(result);
        }
    }

}