using JqueryAjaxAsp.netMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace JqueryAjaxAsp.netMvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAll()
        {
            return View(GetAllEmployees());
        }
        IEnumerable<Employee> GetAllEmployees()
        {
            using(DBEntities db = new DBEntities())
            {
                return db.Employees.ToList<Employee>();
            }
        }

        public ActionResult AddorEdit(int id=0)
        {
            var emp = new Employee();
            return View(emp);
        }

        [HttpPost]
        public ActionResult AddorEdit()
        {
            
            return View();
        }
    }
}