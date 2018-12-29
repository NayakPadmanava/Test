using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Add : IAdd,ISub 
    {
       public  void Sum()
        {
            int i = 10, j = 20;
            Console.WriteLine(i + j);
        }
       void ISub.Sum()
        {
            Console.WriteLine("This is method of ISub");
        }
      public  void Sub()
        {
            Console.WriteLine("Implementation");
        }
        //void  ISub.Sum()
        //{
        //    int i = 10, j = 20;
        //    Console.WriteLine(i + j);
        //}
    }
}
