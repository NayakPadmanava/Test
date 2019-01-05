using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> obList = new List<int>();
            obList.Add(5);
            obList.Add(10);
            int str = obList[1];
            List<Customer> obCustList = new List<Customer>();

            obCustList.Add(new Customer { CustID = 10001, CustName = "ABCX", CustSal = 400 });
            obCustList.Add(new Customer { CustID = 2001, CustName = "XYZ", CustSal = 500 });
            foreach(var custItem in obCustList)
            {
                Console.WriteLine(" CustID ={0}, CustName ={1}, CustSal= {2}", custItem.CustID, custItem.CustName, custItem.CustSal);
            }
            SortedList<int, int> obList1 = new SortedList<int, int>();
            obList1.Add(1, 100);

            Console.ReadLine();

        }
    }
}
