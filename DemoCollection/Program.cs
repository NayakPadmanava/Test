using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DemoQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue ob = new Queue();
            ob.Enqueue("Ashok");
            ob.Enqueue("Anupam");
                ob.Enqueue("Nawab");
            ob.Dequeue();
            ob.Dequeue();
            foreach (var item in ob)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
