using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEncapsulation
{
 public    class DemoAccess
    {
        int k = 10;
        protected void GetAccess()
        {
            Console.WriteLine("Define Scope");


        }

        //public void Add()
        //{
        //    DemoAccess ob1 = new DemoAccess();
        //    ob1.GetAccess();
        //}

    }
   class DerivedClass : DemoAccess
    {
        protected void DemoProtect()
        {
            DemoAccess ob = new DemoAccess();
            

            DerivedClass ob1 = new DerivedClass();
            ob1.GetAccess();
            
        }
    }
}
