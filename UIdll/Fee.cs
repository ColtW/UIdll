//Cheryl Snyder
//Cosc 2330
// 12/12/16
// Fees program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace UIdll
{
    public class Fee : RegisteredCustomer
    {

        ////Cheryl is claiming this class
        // Get the time from the database 
        // Compare the time to the reservations
        // Change the times into standard hours and overcharge hours
        // Set the fees
        // put into invoice form
        // email to clients

        // variables


        public string TheTime { get; set; }
        public double SBill { get; set; }
        public double LBill { get; set; }
        public string CustomerId { get; set; }
        public string SCustomerId { get; set; }
        public string IInvoice { get; set; }
        public string nowTime;
        public string nowDate;
        private bool standard;

        private string sRTimeIn;
        private string sRTimeOut;
        private string sATimeIn;
        private string sATimeOut;

        private string sCustomerID;
        private string sHourlyCharge;
        private double intHourlyCharge;
        private DateTime lngRTimeIn;
        private DateTime lngRTimeOut;
        private DateTime lngATimeIn;
        private DateTime lngATimeOut;
        private DateTime lngRTimeDiff;
        private DateTime lngATimeDiff;
        private DateTime detStandardTime;
        //private Object updateAllCharges;
        private string cCreditCard;
        private int iInvoiceFee;
        SqlConnection connection = new SqlConnection();

        // This method connects to the database and pulls information needed.
        public void ConnectReadAndCloseDataBase()
        {
            nowTime = DateTime.Now.ToString("HH:mm tt");
            nowDate = DateTime.Now.ToString("MMMM:dd:YYYY");



            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
            connection.Open();
            using (SqlCommand readAllReservationsRecords = connection.CreateCommand())
            {
                //readAllReservationsRecords.CommandText = "select * from dbo.Reservations where ActualEndTime = '" + DateTime.Now + "';";
                readAllReservationsRecords.CommandText = "select * from dbo.Reservations;";
                using (SqlDataReader reader = readAllReservationsRecords.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SCustomerId = reader.GetInt32(1).ToString();
                        sRTimeIn = reader.GetString(3);
                        sRTimeOut = reader.GetString(4);
                        sATimeIn = reader.GetString(7);
                        sRTimeOut = reader.GetString(8);
                    }
                }
            }
            using (SqlCommand readAllAllCharges = connection.CreateCommand())
            {
                readAllAllCharges.CommandText = "select * from dbo.AllCharges where HourlyCharge != 0;";

                using (SqlDataReader reader = readAllAllCharges.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sHourlyCharge = reader.GetDouble(2).ToString();
                        SCustomerId = reader.GetInt32(1).ToString();


                    }
                }

            }
            

            using (SqlCommand readAllCustomers = connection.CreateCommand())
            {
                readAllCustomers.CommandText = "select * from dbo.Customers;";

                using (SqlDataReader reader = readAllCustomers.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SCustomerId = reader.GetString(1);

                        cCreditCard = reader.GetString(3);
                    }
                }

            }
            connection.Close();
        }
        public void GetEachCustomer()
        {
            connection.Open();
            using (SqlCommand readAllAllCharges = connection.CreateCommand())
            {
                readAllAllCharges.CommandText = "select * from dbo.AllCharges where CustomerID = '" + CustomerId + "';";

                using (SqlDataReader reader = readAllAllCharges.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        CustomerId = reader.GetInt32(1).ToString();
                        GetChargesPerCustomer();

                    }
                }
            }
            connection.Close();
        }


        public void GetChargesPerCustomer()
        {
            connection.Open();
            using (SqlCommand readAllAllCharges = connection.CreateCommand())
            {
                readAllAllCharges.CommandText = "select * from dbo.AllCharges where CustomerID = '" + CustomerId + "';";
              
                using (SqlDataReader reader = readAllAllCharges.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        SCustomerId = reader.GetString(1);
                        iInvoiceFee += int.Parse(reader.GetString(7));

                    }
                }
            }
            using (SqlCommand upDateAllCharges = connection.CreateCommand())
            {
                upDateAllCharges.CommandText = "update dbo.AllCharges set TotalCharges = '" + IInvoice + "' where CustomerId = '" + SCustomerId + "';";
                upDateAllCharges.ExecuteNonQuery();
            }

            connection.Close();
        }
        // This method changes the strings from the database to usable information
        public void ParseNeededInformation()
        {
            ConnectReadAndCloseDataBase();
            lngRTimeIn = DateTime.ParseExact(sRTimeIn, "yyyy-MM-dd HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture);
            lngRTimeOut = DateTime.ParseExact(sRTimeOut, "yyyy-MM-dd HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture);
            lngATimeIn = DateTime.ParseExact(sATimeIn, "yyyy-MM-dd HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture);
            lngATimeOut = DateTime.ParseExact(sATimeOut, "yyyy-MM-dd HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture);
           
        }
        public void DetermineTime()
        // This method fands the timespan for the visit.
        {


            ParseNeededInformation();
            System.TimeSpan lngRTimeDiff = lngRTimeOut.Subtract(lngRTimeIn);
            System.TimeSpan lngATimeDiff = lngATimeOut.Subtract(lngRTimeIn);
            //System.TimeSpan lngATimeDiff = lngATimeDiff.Subtract(lngATimeDiff);
            System.TimeSpan detStandardTime = lngATimeDiff.Subtract(lngRTimeDiff);

        }
        //This Method determines whether the customer stayed late
        public void DetermineStandardTime()
        {
            DetermineTime();
            if (detStandardTime.Minute >= 15)
            {
                standard = true;
            }
            if (detStandardTime.Minute < 15)
            {
                standard = false;
            }
        }

        // This method determines the fees for the visit
        public void GetBill()
        {
            DetermineTime();
            ConnectReadAndCloseDataBase();
            DetermineStandardTime();
            SBill = double.Parse(sHourlyCharge) * lngRTimeDiff.Minute;
            if (standard == false)
            {
                SBill += (double.Parse(sHourlyCharge) * 2) * (lngATimeDiff.Minute - lngRTimeDiff.Minute);
            }
            UpdateIndividualFee();

        }
        public void UpdateIndividualFee()
        {

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
            connection.Open();

            //SqlCommand getAllAllChargesRecs = connection.CreateCommand();
            using (SqlCommand upDateAllCharges = connection.CreateCommand())
            {
                upDateAllCharges.CommandText = "update dbo.AllCharges set IndividualFee = '" + SBill + "' where CustomerId = '" + SCustomerId + "';";
                upDateAllCharges.ExecuteNonQuery();
            }
            connection.Close();

        }

        // Add fees together and charge customer
    
        public void ChargeCreditCard()
        {
           
            ConnectReadAndCloseDataBase();


            // charge creditcard Invoice Fee
        }


    }
}







