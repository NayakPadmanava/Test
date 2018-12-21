using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class ChildClass:BaseClass
    {
        public ChildClass():base(5)
        {
            Console.WriteLine("Child constructor");
        }
        public void ChildMethod()
        {
            //base.BaseMethod();
            Console.WriteLine("ChildMethod");
        }
    }
}
