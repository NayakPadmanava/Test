using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCustomExcept
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ImpementMyException ob = new ImpementMyException();
                ob.GetItem();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();

        }
    }
}
