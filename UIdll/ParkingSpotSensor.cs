using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace UIdll
{
    public class ParkingSpotSensor : ParkALot
    {

        // Feel free to add to this class as needed!!!******************** 
        // CV Calls this class!
        // This here will show if there is a car in the spot using boolean


        public void DetectAvailability() //Colt added a ParkingSpotSensor object that detects a car
        {
            List<bool> Spots = new List<bool>(400); //list of all 400 available spots
            ParkingSpotSensor detecto9000 = new ParkingSpotSensor();
            
            for(int i = 0; i <= Spots.Count; i++)
            {
                Spots[i] = true; //default sets all spots to open

                if (LicensePlateRecognition.Equals(detecto9000, Spots))
                {
                    Spots[i] = false; //if detecto9000 sees an occupied spot, sets spot to not-available 
                }
                
            }
        }
        
        public bool CarSpot()
        {
            bool carSpotter = true;

            if ( carSpotter == true)
            {
                // If true then the spot is open.
                //bool CarSpot = true;
                Console.WriteLine("This spot is either taken or reserved. Please continue looking for a parking spot.");
                
            }
            else
            {
                // This will show the parking spot is taken.
                // Using a false value.
                Console.WriteLine("This spot is open.");
                
            }
            return carSpotter;
            
        }
    }
}
