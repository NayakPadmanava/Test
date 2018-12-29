using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoStatic ob = new DemoStatic();
            ob.k = 30;
            //DemoStatic.k = 30;
            ob.Method();
            ob.k = 20;
            Console.WriteLine(ob.k); //20
            Console.ReadLine();
        }
    }
}
