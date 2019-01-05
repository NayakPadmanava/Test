using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DemoStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack ob = new Stack();
            ob.Push(10);
            ob.Push(20);
           // ob.Push(null);
            
            //Console.WriteLine(ob.Pop());
            Console.WriteLine(ob.Peek()); //20
            Console.WriteLine(ob.Pop()); //20
            foreach (var dt in ob)
            {
                Console.WriteLine(dt); //10
            }
            Console.ReadLine();
        }
    }
}
