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
            /*
            EmployeesContext employeesContext = new EmployeesContext();
            var resault = employeesContext.Employees.ToList();*/
            EmployeeSeed employeeSeed = new EmployeeSeed();
            var  resault=  employeeSeed.emplist;
            return Json(resault, JsonRequestBehavior.AllowGet);
        }
       
        [HttpPost]
        public JsonResult UpdateEmpl(int id , int salary )

        {

EmployeeSeed employeeSeed = new EmployeeSeed();
       employeeSeed.emplist.Single(emp => emp.Id == id).Salary = salary;

            return Json(employeeSeed.emplist, JsonRequestBehavior.AllowGet);
        }

    }
}