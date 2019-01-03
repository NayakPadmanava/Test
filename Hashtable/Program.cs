using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable obList = new Hashtable();
            obList.Add("Name", "Naveen");
            obList.Add("age", 100);
            obList.Add("sal", 10000);
            Console.WriteLine(obList.Count);
            //foreach(DictionaryEntry ar in obList)
            //{
            //    Console.WriteLine("Key:{0}, value:{1}", ar.Key,ar.Value);
            //}
            //obList.Clear();
            foreach(var key in obList.Keys)
            {
                Console.WriteLine(key.ToString());
            }
            foreach (var key in obList.Values)
            {
                Console.WriteLine(key.ToString());
            }
            //obList.Remove("Name");
            //foreach (var key in obList.Keys)
            //{
            //    Console.WriteLine(key.ToString());
            //}

            //Console.WriteLine(obList["age"].ToString());

            Console.ReadLine();
        }
    }
}
