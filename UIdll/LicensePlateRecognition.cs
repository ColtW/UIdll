using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string ElevatorLicenseCam()
        {
            // storage for license plate
            string licensePlate = String.Empty;

            try
            {                
                OCR = licensePlate;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return licensePlate;
        }

        public string ExitLicenseCam()
        {
            // storage for license plate
            string licensePlate = String.Empty;

            try
            {
                OCR = licensePlate;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return licensePlate;
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
