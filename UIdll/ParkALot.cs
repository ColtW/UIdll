using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIdll
{
    public class ParkALot
    {
        // Properties for Lot Numbers and Floor distinction
        public int LotNumber { get; set; }
        public string LotFloor { get; set; }

        // method to get the Lot ID
        public string GetLotID()
        {
            string lotID = "";
            lotID = LotFloor + LotNumber.ToString();
            return lotID;
        }
    }

    
}
