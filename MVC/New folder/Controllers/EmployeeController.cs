using DemoModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoModel.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Employee()
        {
            Employee obemp = new Employee();
            List<Employee> oblist = obemp.GetEmployees();
            ViewBag.EmpDtl = oblist;
            

            return View();
        }
        public ActionResult EmployeeViewData()
        {
            Employee obemp = new Employee();
            List<Employee> oblist = obemp.GetEmployees();
            ViewData["Empdtl1"] = oblist;

            return View();
        }


    }
}