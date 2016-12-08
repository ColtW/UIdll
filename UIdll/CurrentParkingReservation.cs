using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

namespace UIdll
{
    public class CurrentParkingReservation : RegisteredCustomer
    {
        // search database for current reservation with ID from persons class

        SqlConnection connection = new SqlConnection();

        public string reservation()
        {
            using (SqlCommand searchPlate = connection.CreateCommand())
            {
                // in this method we will finish the code to search and return whether or not the customer has a reservation

                // searchPlate.CommandText = "select * from db_tablename.field where Field = 'exactmatch';";
            }

            return "";
        }

        
    }
}
