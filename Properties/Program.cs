using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BookGrade ob = new BookGrade();
            ob.Marks = 40;
            ob.Percentage = 40;
            ob.Name = "Naveen";
            //ob.Grade = 60;

            Console.WriteLine(ob.Marks);
            Console.WriteLine(ob.Percentage);
            Console.WriteLine(ob.Grade);
            Console.WriteLine(ob.Name);
            Console.ReadLine();
        }
    }
}
