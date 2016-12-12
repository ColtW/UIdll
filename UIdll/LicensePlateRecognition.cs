using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

namespace UIdll
{
    // Claim for Josiah's Class
    public class LicensePlateRecognition : VehicleElevator
    {
        // Taking a picture and converting it into a string of letters and numbers
        // which will then see if it matches with any registered customers or members
        // if not then they will be asked to input their id, and the license plate will be deemed
        // a temporary association with the account.
        // if there is none, they will still be asked for id, but the license plate wont be added

        // Something to represent a Optical camera recognition
        public object OCR { get; set; }

        public void ElevatorLicenseCam(DateTime time, string licensePlateResult)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();
            Console.WriteLine(connection.ServerVersion);

            // storage for license plate
            string licensePlate = String.Empty;
            bool tryAgain = false;

            try
            {       
                OCR = licensePlate;
                using (SqlCommand readAllLicensePlates = connection.CreateCommand())
                {
                    readAllLicensePlates.CommandText = "select * dbo.Customers";

                    using (SqlDataReader reader = readAllLicensePlates.ExecuteReader())
                    {
                        
                        string licensePlateMatch = "";
                        do
                        {
                            reader.Read();
                            licensePlateMatch = reader.GetString(8);
                            if(licensePlate == licensePlateMatch)
                            {
                                time = DateTime.Now;
                                licensePlateResult = licensePlate;
                                tryAgain = true;
                            }
                            else
                            {
                                licensePlateResult = licensePlate;
                                time = DateTime.Now;
                            }
                        }
                        while (tryAgain == true);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            connection.Close();
        }

        public void ExitLicenseCam(DateTime time, string licensePlateResult)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=project2;User Id=db2;Password = db20;";
            connection.Open();
            Console.WriteLine(connection.ServerVersion);

            // storage for license plate
            string licensePlate = String.Empty;
            bool tryAgain = false;

            try
            {
                OCR = licensePlate;
                using (SqlCommand readAllLicensePlates = connection.CreateCommand())
                {
                    readAllLicensePlates.CommandText = "select * dbo.Customers";

                    using (SqlDataReader reader = readAllLicensePlates.ExecuteReader())
                    {

                        string licensePlateMatch = "";
                        do
                        {
                            reader.Read();
                            licensePlateMatch = reader.GetString(8);
                            if (licensePlate == licensePlateMatch)
                            {
                                time = DateTime.Now;
                                licensePlateResult = licensePlate;
                                tryAgain = true;
                            }
                            else
                            {
                                licensePlateResult = licensePlate;
                                time = DateTime.Now;
                            }
                        }
                        while (tryAgain == true);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
        }

        public bool ElevatorOccupancy()
        {
            bool occupancy = false;

            try
            {
                if(OCR != null)
                {
                    occupancy = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return occupancy;
        }
    }
}
