using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoModel.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSal { get; set; }

        public List<Employee> GetEmployees()
        {
            List<Employee> oblist = new List<Employee> { new Employee { EmpId =1, EmpName="ABC", EmpSal=100}
                                                        ,new Employee{ EmpId =2, EmpName ="XYZ", EmpSal=1000}
                                                        , new Employee {EmpId = 3, EmpName="PQR",EmpSal=5000 } };

            return oblist;
        }
    }
}