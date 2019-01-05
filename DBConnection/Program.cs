using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DemoDBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Program ob = new Program();
            //ob.AddCustomer();
             ob.GetCustomer();
            //ob.GetCustomerID(1002);
           // ob.GetCustomerIDWithSP(1001);
            
            Console.ReadLine();
        }

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
            SqlDataReader obReader = obCmd.ExecuteReader();
            while(obReader.Read())
            {
                Console.WriteLine(" custID={0}, CustName={1}, CustPhone ={2}, custAdd= {3}",
                                      obReader[0], obReader[1], obReader[2], obReader[3]);
            }
            obCon.Close();

        }
        public void GetCustomerID(int custId)
        {
            //Step 1
            string ConnectionStr = "data source =localhost; initial catalog= SDLC; Integrated Security=True;";
            //step 2
            SqlConnection obCon = new SqlConnection(ConnectionStr);
            //step 3
            obCon.Open();
            //step 4 
            SqlCommand obCmd = new SqlCommand("select * from Customer where CustID=@custId", obCon);

            SqlParameter ob = new SqlParameter("@custId",custId);
            obCmd.Parameters.Add(ob);
            //step 5
            SqlDataReader obReader = obCmd.ExecuteReader();
            while (obReader.Read())
            {
                Console.WriteLine(" custID={0}, CustName={1}, CustPhone ={2}, custAdd= {3}",
                                      obReader[0], obReader[1], obReader[2], obReader[3]);
            }
            obCon.Close();


        }
        public void GetCustomerIDWithSP(int custId)
        {
            //Step 1
            string ConnectionStr = "data source =localhost; initial catalog= SDLC; Integrated Security=True;";
            //step 2
            SqlConnection obCon = new SqlConnection(ConnectionStr);
            //step 3
            obCon.Open();
            //step 4 
            SqlCommand obCmd = new SqlCommand("GetCustomer_SP", obCon);
            obCmd.CommandType =CommandType.StoredProcedure;

            SqlParameter ob = new SqlParameter("@Param_custId", DbType.Int32);
            obCmd.Parameters.Add(ob).Value=custId;
            //step 5
            SqlDataReader obReader = obCmd.ExecuteReader();
            while (obReader.Read())
            {
                Console.WriteLine(" custID={0}, CustName={1}, CustPhone ={2}, custAdd= {3}",
                                      obReader[0], obReader[1], obReader[2], obReader[3]);
            }
            obCon.Close();


        }
        public void AddCustomer()
        {
            //Step 1
            string ConnectionStr = "data source =localhost; initial catalog= SDLC; Integrated Security=True;";
            //step 2
            SqlConnection obCon = new SqlConnection(ConnectionStr);
            //step 3
            obCon.Open();
            SqlCommand obCmd = new SqlCommand("insert Customer(CustID,CustName,CustAddress,CustPhone) values (1004,'Arjun','Marathalli',123456)", obCon);

            obCmd.ExecuteNonQuery();

        }
    }
}
