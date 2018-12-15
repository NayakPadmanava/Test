using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook ob = new GradeBook(67);
            GradeBook obj = new GradeBook(ob);
            ob.AddGrade(30);
            Console.WriteLine(ob.AddGrade(30));
            Console.ReadLine();
        }
    }
}
