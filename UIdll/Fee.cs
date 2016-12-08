using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIdll
{
	public class Fee : RegisteredCustomer
	{
		//Variables to find time in spot
		////Cheryl is claiming this class
		////msdn.microsoft.com
		private int theTime;
		private int timeStamp = 0;
		public string TheTime { get; set; }
		public int SBill { get; set; }
		public int LBill { get; set; }
		private bool standard;
		private int standardTime;
		public void GetBill()
		
		{
			if(standard == true)
				{
					SBill = 2 * timeStamp;
				}
			else if(standard == false)
				{
				
				LBill = 3 * (timeStamp - standardTime);
				}
		}	
		
	}
}
	




    
}
