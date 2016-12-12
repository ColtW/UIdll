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
        

        public string reserveID { get; set; }
        public string confirmation { get; set; }
        public string reserveDate { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string spaceNumber { get; set; }
        public string custID { get; set; }

        public void searchReservation()
        {
            connection.Open();
            using (SqlCommand searchID = connection.CreateCommand())
            {
                // in this method we will finish the code to search and return whether or not the customer has a reservation
                
                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                searchID.CommandText = "select * from dbo.Reservations where ReservationID = '" + reserveID + "';";

                using (SqlDataReader reader = searchID.ExecuteReader())
                {
                    confirmation = reader.GetString(1);
                    reserveDate = reader.GetString(2);
                    start = reader.GetString(3);
                    end = reader.GetString(4);
                    spaceNumber = reader.GetString(5);
                    custID = reader.GetString(6);

                }

                
            }
        }

        // the following method will add a new reservation to the database
        public void newReservation()
        {
            connection.Open();
            using (SqlCommand addReservation = connection.CreateCommand())
            {
                // in this method the code will add a new reservation to the database
                
                connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
                addReservation.CommandText = "insert into dbo.Reservations values ('enter all fields here');";
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
