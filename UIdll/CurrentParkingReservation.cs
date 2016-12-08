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

        public string searchReservation()
        {
            using (SqlCommand searchPlate = connection.CreateCommand())
            {
                // in this method we will finish the code to search and return whether or not the customer has a reservation

                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                // searchPlate.CommandText = "select * from db_tablename.field where Field = 'exactmatch';";
            }

            return "";
        }

        // the following method will add a new reservation to the database
        public void newReservation()
        {
            using (SqlCommand addReservation = connection.CreateCommand())
            {
                // in this method the code will add a new reservation to the database

                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                // addReservation.CommandText = "insert into db_tablename.field values ('enter all fields here');";
                // addReservation.ExecuteNonQuery();
            }
        }

        public void deleteReservation()
        {
            using (SqlCommand eraseReservation = connection.CreateCommand())
            {
                // in this method a customer can cancel a reservation

                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";

                // eraseReservation.CommandText = "delete from db_tablename.primarykeyfield where field = 'exactmatch';";
            }
        }

        
    }
}
