using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
             ISub ob = new Add();
            Add ob1 = new Add();
            ob.Sum();
            ob1.Sub();
           // IAdd ob1 = new Add();
            //ob1.Sum();
            Console.ReadLine();
        }
    }
}
