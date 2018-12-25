using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEncapsulation
{
    class Program :DemoAccess
    {
       public static void Main(string[] args)
        {
            DemoAccess ob = new DemoAccess();

            Program ob1 = new Program();
            ob1.GetAccess();

        }
    }
}
