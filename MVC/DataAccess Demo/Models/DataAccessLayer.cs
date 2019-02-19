using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CustomerManagement.Models
{
    public class DataAccessLayer
    {
        public List<Customer> GetCustomer()
        {
            List<Customer> obList = new List<Customer>();
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
            while (obReader.Read())
            {
                Customer obCust = new Customer();
                obCust.CustId = Convert.ToInt32(obReader[0].ToString());
                obCust.CustName = obReader[1].ToString();
                obCust.CustAddress = obReader[3].ToString();
                obCust.CustPhone = Convert.ToInt64(obReader[2].ToString());
                obList.Add(obCust);

                
            }
            obCon.Close();

            return obList;

        }

    }
}