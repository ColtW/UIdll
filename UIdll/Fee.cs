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
		// Get the time from the liscense plate reader 
		// Compare the time to the reservations
		// Change the times into standard hours and overcharge hours
		// Set the fees
		// put into invoice form
		// email to clients

			// variables
		private int theTime;
		private int timeStamp = 0;
		public string TheTime { get; set; }
		public int SBill { get; set; }
		public int LBill { get; set; }
		private bool standard;
		private int standardTime;
		private int RTimeIn;
		private int RTimeOut;
		private int ATimeIn;
		private int ATimeOut;
		SqlConnection connection = new SqlConnection();
		//Server=cis1.actx.edu;Database=project;User Id = db2; Password = db20;
		//connection.ConnectionString = "Server=cis1.actx.edu;Database=project;User Id=project;Password = project1;";
		//connection.Open();
		//using (SqlCommand readAllProfessorRecords = connection.CreateCommand())
		//          {
		//              readAllProfessorRecords.CommandText = "select * from db_owner.Professor where FirstName = 'Dewayne';";

		//              using (SqlDataReader reader = readAllProfessorRecords.ExecuteReader())
		//              {
		//                  string rec = "";
		//                  while (reader.Read())
		//                  {
		//                      RTimeIn = reader.GetString(1);
		//                      RTimeOut= reader.GetString(2);
		//                      ATimeIn = reader.GetString(3);
		//						ATimeOut = reader.GetString(4);
		//                     
		//						}
		//					 }
		//				}

		//public static DateTime FromUnixTime(this long unixTime)
		//{
		//	var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		//	return epoch.AddSeconds(unixTime);
		//}
	//public static long ToUnixTime(this DateTime date)
	//{
	//	var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
	//	return Convert.ToInt64(date - epoch).TotalSeconds);
	//}
	//public bool DetermineStandardTime(standard);
	//{
	//	if (ATimeOut >= RTimeOut)
	//	{
	//		standard = false;
	//	}
	//}


	//public void GetBill()
	//	{
	//		SBill = 2 * timeStamp;
	//		if (standard == false)
	//		{
	//			LBill = 4 * (timeStamp - standardTime) + SBill;
	//		}
	//	}
}
}
	




    

