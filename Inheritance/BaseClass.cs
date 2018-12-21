using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass Constructor");
        }
        public BaseClass(int k)
        {
            Console.WriteLine("Parameterize constructor");
        }
        public void BaseMethod()
        {
            Console.WriteLine("BaseMethod");
        }
    }
}
