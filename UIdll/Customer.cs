using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIdll
{
    //Spencer claims this class
    public class Customer : Person
    {   //Colt isn't claiming this class but offering suggestions based on what I did in the Person superclass
        //check out my fields I declared in Person, make an operator object, and set the fields accordingly.
        public void MakeCustomer()
        {
            Operator nonMember = new Operator();

            nonMember.securityClearenceLevel = 1;

            nonMember.ID = 0;

            nonMember.name = "";

            nonMember.DOB = 0;
        }
       

        
        

    }
}
