using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIdll
{
    //Spencer claims this class
     public class RegisteredCustomer : Customer
    {//Colt isn't claiming this class but offering suggestions based on what I did in the Person superclass
     //check out my fields I declared in Person, make an operator object, and set the fields accordingly.
     
        public void MakeRegistaredCustomer()
        {
            Operator mrc = new Operator();

            mrc.securityClearenceLevel = 2;

            mrc.ID = 0;

            mrc.name = "";

            mrc.DOB = 0;
        }
    }
}
