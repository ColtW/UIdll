using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIdll
{
    public class ParkingSpotSensor : ParkALot
    {
        // CV Calls this class!
        // This here will show if there is a car in the spot using boolean
        public bool CarSpot()
        {
            if( true)
            {
                // If true then the spot is open.
                CarSpot = true;
                
            }
            else
            {
                // This will show the parking spot is taken.
                // Using a false value.
            }
        }
    }
}
