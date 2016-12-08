using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIdll
{
    // Trevor B will take this class on
    public class SecurityGaurd : Employee
    {
        public void MakeSecurityGuard()
        {
            SecurityGaurd dwight = new SecurityGaurd();
            dwight.name = "Dwight Schrute";
            dwight.username = "dwightschrute";
            dwight.password = "bearsbeets";
            dwight.securityClearenceLevel = 3;
        }
    }
}
