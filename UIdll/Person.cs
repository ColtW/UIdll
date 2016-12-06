using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIdll
{
    public class Person : ParkALot 
    {//Colt calls dibs on the Person class.
     //this class will declare properties that all persons will use

        public int ID;                    //Allows for employees to sign in and customers to access/store vehicles
        public int DOB;                   //verification purposes
   
        public int securityClearenceLevel; //sets access allowance to people of different accounts (employee, guest, registered customer)

                                           //perhaps securityClearenceLevel 1 for guests, 2 for registered, 3 for security guard, and 4 for operator
                                                //if security level 1 --> lift both gates (one in front of elevator and one after) and allow parking on floor 1
                                                //if security level 2 --> lift first gate and elevate car (if sensor detects car) to appropriate floor
                                                //if security level 3 --> open security guard UI? or maybe just camera feed
                                                //if security level 4 --> open operator UI

        public string name;                  //additional verification? may scrap

    }
}
