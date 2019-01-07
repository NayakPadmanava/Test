using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDBConnection
{
    class DataAdapter
    {
        public void GetCustomer()
        {
            //Step 1
            string ConnectionStr = "data source =localhost; initial catalog= SDLC; Integrated Security=True;";
            //step 2
            SqlConnection obCon = new SqlConnection(ConnectionStr);
            //step 3
            obCon.Open();
            //step 4
            SqlCommand obCmd = new SqlCommand("select * from Customer", obCon);
            //step 5
            //SqlDataReader obReader = obCmd.ExecuteReader();
            SqlDataAdapter obAdapter = new SqlDataAdapter(obCmd);
            DataSet ds = new DataSet();
            obAdapter.Fill(ds);
            foreach(DataTable dt in ds.Tables)
            {
                foreach( DataRow dr in dt.Rows)
                {
                    foreach(DataColumn dc in dt.Columns)
                    {
                        Console.WriteLine(dr[dc]);
                    }
                }
            }
            //while (obReader.Read())
            //{
            //    Console.WriteLine(" custID={0}, CustName={1}, CustPhone ={2}, custAdd= {3}",
            //                          obReader[0], obReader[1], obReader[2], obReader[3]);
            //}
            obCon.Close();

        }
        
    }
}
