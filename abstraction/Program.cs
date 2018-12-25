using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer ob = new Customer();  

            DerivedCustomer ob = new DerivedCustomer();
            ob.Sum();
            ob.GetCust();
            Console.ReadLine();
        }
    }
}
