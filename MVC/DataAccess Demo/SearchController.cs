using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerManagement.Models;

namespace CustomerManagement.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCustomer()
        {
            Customer ob = new Customer();
            ob.CustId = 100;
            ob.CustName = "Srujana";
            ob.CustAddress = "Kadapa";

            return PartialView("_GetCustomer", ob);
        }
    }
}