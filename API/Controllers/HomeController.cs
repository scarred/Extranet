using API.DAL;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            if (employee.ID.Equals(Guid.Empty))
                employee.ID = new Guid();

            if (!ModelState.IsValid)
                return View("Index", employee);
            else
            {
                EmployeeContext db = new EmployeeContext();
                db.Employees.Add(employee);
                db.SaveChanges();

                return View("Index");
            }
        }
    }
}