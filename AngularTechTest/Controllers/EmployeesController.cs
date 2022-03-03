using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using AngularTechTest.Models;
namespace AngularTechTest.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
         
            return View();
        }
        [HttpGet]
        public JsonResult GetEmpl()

        {
            EmployeesContext employeesContext = new EmployeesContext();
            var resault = employeesContext.Employees.ToList();
            return Json(resault, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult UpdateEmpl(int id , int salary  )

        {
            EmployeesContext employeesContext = new EmployeesContext();
            employeesContext.Employees.Single(emp=>emp.Id==id ).Salary = salary;
            employeesContext.SaveChanges();
            return Json(employeesContext, JsonRequestBehavior.AllowGet);
        }

    }
}