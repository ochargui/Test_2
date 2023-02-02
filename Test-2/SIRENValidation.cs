using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class SIRENValidation : IAmTheTest
    {
        public bool CheckSiretValidity(string siren)
        {
            throw new NotImplementedException();
        }

        public bool ValidateSIREN(string siren)
        {
            if (siren.Length != 9)
                return false;

            int sum = 0;
            bool isSecond = false;
            for (int i = siren.Length - 1; i >= 0; i--)
            {
                int n = int.Parse(siren[i].ToString());
                if (isSecond == true)
                    n *= 2;

                sum += n % 10 + n / 10;
                isSecond = !isSecond;
            }

            return (sum % 10 == 0);
        }
       
    }
}



