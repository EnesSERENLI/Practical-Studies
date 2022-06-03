using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_CRUDs.Models;

namespace WebApi_CRUDs.Controllers
{
    public class EmployeesController : ApiController
    {
        NorthwindEntities db = new NorthwindEntities();

        public List<EmployeeDTO> EmployeeList()
        {
            var emloyees = db.Employees.Select(x => new EmployeeDTO
            {
                Id = x.EmployeeID,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Title = x.Title
            }).ToList();
            return emloyees;
        }
        public IHttpActionResult GetEmployee()
        {
            return Json(EmployeeList());
        }

        public IHttpActionResult PostAddEmployee(string title,string firstName,string lastName)
        {
            try
            {
                Employee employee = new Employee();
                employee.FirstName = firstName;
                employee.LastName = lastName;
                employee.Title = title;
                if (employee != null)
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    return Json(EmployeeList()); 
                }
                else
                {
                    return BadRequest("Veri bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        public IHttpActionResult DeleteEmployee(int id)
        {
            Employee deleted = db.Employees.FirstOrDefault(x => x.EmployeeID == id);
            try
            {
                if (deleted != null)
                {
                    db.Employees.Remove(deleted);
                    db.SaveChanges();
                    return Json(EmployeeList());
                }
                else
                {
                    return BadRequest("veri bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }

        public IHttpActionResult PutEmployee(int id, string title, string firstName, string lastName)
        {
            try
            {
                Employee updated = db.Employees.Find(id);
                if (updated != null)
                {                    
                    updated.Title = title;
                    updated.FirstName = firstName;
                    updated.LastName = lastName;
                    db.Entry(updated).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return Ok(EmployeeList()); 
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
