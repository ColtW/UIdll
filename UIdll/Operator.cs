using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIdll
{
    public class Operator : Employee
    {//Colt IS claiming this class now
        public void MakeOperator()
        {
            Operator billy = new Operator();
            billy.DOB = 1987;
            billy.ID = 044272;
            billy.name = "Billy McPearson";
            billy.securityClearenceLevel = 4;
        }
    }
}
