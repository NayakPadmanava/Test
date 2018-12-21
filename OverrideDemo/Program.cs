using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            studentChild ob = new studentChild();
            ob.Add();
            MasterBase ob1 = new MasterBase();
            ob1.Add();

            MasterBase ob2 = new studentChild();
            ob2.Add();
            Console.ReadLine();
        }
    }
}
