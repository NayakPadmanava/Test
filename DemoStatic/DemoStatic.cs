using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStatic
{
    class DemoStatic
    {
        //public  static int k = 10;
        public  int k = 10;
        public  void Method()
        {
            Console.WriteLine(k); 
            k = 67;
            Console.WriteLine(k); //5  //10
        }
        

    }
}
