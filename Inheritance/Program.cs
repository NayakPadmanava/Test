using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildClass ob = new ChildClass();

            //ChildClass ob1 = new ChildClass(8);
            ob.BaseMethod();
            ob.ChildMethod();

            //BaseClass ob1 = new BaseClass(8);
            Console.ReadLine();
        }
    }
}
