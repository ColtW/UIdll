using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIdll
{
    public class Levels : ParkALot
    {
        // This here should only be for the free for all parking if there are any left.
        // Show level 1 which is ground level is for guests
        // upper level are for memebers and reservations
        public int Member ()
        {
            Person clearLevel = new Person();
            clearLevel.securityClearenceLevel = 0;
            if(clearLevel.securityClearenceLevel = 1)
            {
                // They can only park on the ground level
                Console.WriteLine("Guest parking is on the ground level. Please proceed to find a guest parking.");
            }
            else if( clearLevel.securityClearenceLevel = 2 && 3 && 4)
            {
                Console.WriteLine("Membership and reserved parking is on the upper level! Please proceed to the elevator.");
            }
            
            return Member();
        }
    }
}
