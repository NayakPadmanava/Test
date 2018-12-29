using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int k = 10;
                int i = 1;
                int divide = k / i;
                Console.WriteLine(divide);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                Console.WriteLine("This is my Finally block");
            }
            Console.ReadLine();
        }
    }
}
