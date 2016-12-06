using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIdll
{
    // Sawyer's class
    public class GuestCustomer : Customer
    {//Colt isn't claiming this class but offering suggestions based on what I did in the Person superclass
     //check out my fields I declared in Person, make an operator object, and set the fields accordingly.

        // Feel free to add or make suggestions as needed


        private string Name { get; set; }
        private string LicenseNumber { get; set; }
        public int securityClearanceLevel = 1;

        public string ParkCar()
        {
            return "The guest parks the car in the open space";
        }



        public void CheckForOpenSpace()
        {
            bool CarSpot = true;
            if(CarSpot == true)
            {
                ParkCar();
            }
            else
            {
                Console.WriteLine("There were no open spaces");
            }
        }

    }
}
