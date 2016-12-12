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
            //make this class talk to the customer window form.
            Customer nonMember = new Customer();

            nonMember.securityClearenceLevel = 1;

            nonMember.username = "0";

            nonMember.name = "";

            nonMember.password = "0";
        }
       

        
        

    }
}
