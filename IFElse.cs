using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Color");
            string color = Console.ReadLine();
            bool flag = true;
            int i = 5;
            if (color == "Red")
            {
                Console.WriteLine("Color Is Red");
            }
            else if (color == "Blue")
            {
                Console.WriteLine("color is Blue");
            }
            else
            {
                Console.WriteLine("Color is not matching");
            }
            Console.ReadLine();
        }
    }
}
