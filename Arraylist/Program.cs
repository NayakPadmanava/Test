using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obArrayList = new ArrayList();
            obArrayList.Add(50);
            obArrayList.Add("Naveen:Anupam");
            obArrayList.Add("Arjun");
            obArrayList.Add('M');
            obArrayList.Add("SDLC");
            Console.WriteLine(obArrayList.Count);
            
            obArrayList.Capacity = 10;
            
            foreach( var ar in obArrayList)
            {
                Console.WriteLine(ar);
            }
            obArrayList.Remove("Naveen:Anupam");
             obArrayList.Insert(0, 100);
            foreach (var ar in obArrayList)
            {
                Console.WriteLine(ar);

            }

             obArrayList.Insert(0, 200);
            obArrayList.RemoveAt(1);
            foreach (var ar in obArrayList)
            {
                Console.WriteLine(ar);

            }


            Console.ReadLine();
        }
    }
}
