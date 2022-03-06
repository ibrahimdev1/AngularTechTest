using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularTechTest.Models
{
    public class EmployeeSeed
    {
        public  List<Employees> emplist = new List<Employees> { };
        public EmployeeSeed()
        {
            
            Employees emp1 = new Employees() { Id = 1, Department = "IT", Name = "John", Salary = 150000 }; emplist.Add(emp1);
            Employees emp2 = new Employees() { Id = 2, Department = "HR", Name = "Rimi", Salary = 200000 }; emplist.Add(emp2);
            Employees emp3 = new Employees() { Id = 3, Department = "Operation", Name = "Jim", Salary = 50000 }; emplist.Add(emp3);
            Employees emp4 = new Employees() { Id = 4, Department = "IT", Name = "Dev", Salary = 150000 }; emplist.Add(emp4);
            Employees emp5 = new Employees() { Id = 5, Department = "HR", Name = "Sarah", Salary = 60000 }; emplist.Add(emp5);
            Employees emp6 = new Employees() { Id = 6, Department = "IT", Name = "Seteve", Salary = 170000 }; emplist.Add(emp6);
            Employees emp7 = new Employees() { Id = 7, Department = "Operation", Name = "Henry", Salary = 60000 }; emplist.Add(emp7);
            Employees emp8 = new Employees() { Id = 8, Department = "IT", Name = "Tony", Salary = 80000 }; emplist.Add(emp8);
            Employees emp9 = new Employees() { Id = 9, Department = "IT", Name = "Ema", Salary = 85000 }; emplist.Add(emp9);
            Employees emp10 = new Employees() { Id = 10, Department = "Operation", Name = "Dani", Salary = 90000 }; emplist.Add(emp10);

    
        }
    }
}