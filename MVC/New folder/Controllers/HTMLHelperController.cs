using DemoModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoModel.Controllers
{
    public class HTMLHelperController : Controller
    {
        // GET: HTMLHelper
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DemoStronglyTyped()
        {
            Employee obEmp = new Employee();
            obEmp.EmpId = "100";
            obEmp.EmpName = "Srujana";
            obEmp.EmpSal = 24000;
            
            return View(obEmp);
        }
    }
}