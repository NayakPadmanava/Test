using CustomerManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerManagement.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCustomer()
        {
            DataAccessLayer obData = new DataAccessLayer();
            var data = obData.GetCustomer();
            return View(data);
        }
        [ValidateInput(false)]
        public ActionResult CreateUser( Customer objCust)
        {

            return View();
        }


    }
}