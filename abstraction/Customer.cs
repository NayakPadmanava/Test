using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstraction
{
   public abstract class Customer
    {
      public  abstract void Sum();
        public void GetCust()
        {
            Console.WriteLine("This is my Normal method");
        }
    }

    public class DerivedCustomer : Customer
    {
        public override void Sum()
        {
            Console.WriteLine("Sum is Summation of two Number");
        }
    }
}
