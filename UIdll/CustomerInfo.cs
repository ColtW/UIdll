using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

namespace UIdll
{
    //Spencer claims this class
    public class CustomerInfo : RegisteredCustomer
    {
        static void Main(string[] args)
        {
            //This class will be used to insert info on customers into the data base.SR
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;DataBase=project2;User Id=db2;Password = db20;";
            //above this is were we put in the info for our server what ever it happens to be.//
            connection.Open();
            //the following is for the insertion of data into the table of our DB
            using (SqlCommand insertNewCustomer = connection.CreateCommand())
            {
                insertNewCustomer.CommandText = "insert into db2.Customer values();";
                insertNewCustomer.ExecuteNonQuery();
            }

            //The folwing code is for the retrieval of data from the DB
            using (SqlCommand readAllCustomerRecords = connection.CreateCommand())
            {
                readAllCustomerRecords.CommandText = "select * from db_owner.Customer;";

                using (SqlDataReader reader = readAllCustomerRecords.ExecuteReader())
                {
                    //this is where we can minipulate the data 
                    string rec = "";
                    while (reader.Read())
                    {
                        rec = reader.GetString(1) + "whatever we need";
                        Console.WriteLine(rec);// this might need to get displayed via a windows form.
                    }
                }
            }

        }
        
        

       
    }
}
