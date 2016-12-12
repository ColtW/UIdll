using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
;
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
		public long SBill { get; set; }
		public long LBill { get; set; }
		private bool standard;
		private string standardTime;
		private string sRTimeIn;
		private string sRTimeOut;
		private string sATimeIn;
		private string sATimeOut;
		private string StandardTime;
		//private long lngRTimeIn;
		//private long lngRTimeOut;
		//private long lngATimeIn;
		//private long lngATimeOut;
		private long lngRTimeDiff;
		private long lngATimeDiff;
		private long detStandardTime;
		private string Name = "";
		DateTime lngRTimeIn = DateTime.ParseExact("RTimeIn", "HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
		DateTime lngRTimeOut = DateTime.ParseExact("RTimeOut", "HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
		DateTime lngATimeIn = DateTime.ParseExact("ATimeIn", "HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
		DateTime lngATimeOut = DateTime.ParseExact("ATimeOut", "HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
		public void ConnectAndCloseDataBase()
		{
			SqlConnection connection = new SqlConnection();
			connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password = db20;";
			connection.Open();
			using (SqlCommand readAllReservationsRecords = connection.CreateCommand())
			{
				readAllReservationsRecords.CommandText = "select * from dbo.Reservations where ReservationID = 'Name';";

				using (SqlDataReader reader = readAllReservationsRecords.ExecuteReader())
				{

					while (reader.Read())
					{
						sRTimeIn = reader.GetString(3);
						sRTimeOut = reader.GetString(4);
						sATimeIn = reader.GetString(7);
						sRTimeOut = reader.GetString(8);

					}
				}
			}
		}
		public void ConvertStringtoTime()
		{
			//DateTime lngRTimeIn = DateTime.ParseExact("RTimeIn", "HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
			//DateTime lngRTimeOut = DateTime.ParseExact("RTimeOut", "HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
			//DateTime lngATimeIn = DateTime.ParseExact("ATimeIn", "HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
			//DateTime lngATimeOut = DateTime.ParseExact("ATimeOut", "HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
			
		}

		public void DetermineTime()
		{
			System.TimeSpan lngRTimeDiff = lngRTimeOut.Subtract(lngRTimeIn);
			System.TimeSpan lngATimeDiff = lngATimeOut.Subtract(lngATimeIn);
			System.TimeSpan detStandardTime = lngRTimeDiff.Subtract(lngRTimeDiff);
		}
		public void DetermineStandardTime()
		{
			if (detStandardTime >= 0)
			{
				standard = true;
			}
			if (detStandardTime < 0)
			{
				standard = false;
			}
		}
		//public bool DetermineStandardTime()
		//{
		//	if (detStandardTime > 0)
		//	{
		//		return false;
		//	}
		//	else
		//	{
		//		return true;
		//	}
		//}


		public void GetBill()
		{
			SBill = 2 * lngRTimeDiff;
			if (standard == false)
			{
				LBill = 4 * (lngATimeDiff - lngRTimeDiff) + SBill;
			}

		}
	}
}
	




    

