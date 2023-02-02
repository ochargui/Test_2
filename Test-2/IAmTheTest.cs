using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    public  interface IAmTheTest
    {
     
        bool ValidateSIREN(string siren);
        bool CheckSiretValidity(string siren);
    }
}
