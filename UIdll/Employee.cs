using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIdll
{
    //TEST TEST

    //Ralph calls this class
    public class Employee : Person
    {//Colt isn't claiming this class but offering suggestions based on what I did in the Person superclass
     //check out my fields I declared in Person, make an operator object, and set the fields accordingly.

        public void MakeEmployee()
        {
            Operator worker = new Operator();

            worker.DOB = 1982;

            worker.ID = 038571;

            worker.name = "Jethro ";

            worker.securityClearenceLevel = 4;
        }
    }
}
