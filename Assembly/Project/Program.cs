using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoAssembly;

namespace UsingAssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PA ob = new PA();
            string str = ob.GetMethod();

            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
