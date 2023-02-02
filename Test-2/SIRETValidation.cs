using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    public class SIRETValidation : IAmTheTest
    {
        public bool CheckSiretValidity(string siren)
        {
            if (siren.Length != 14)
            {
                return false;
            }

            int sum = 0;
            bool alternate = false;
            for (int i = siren.Length - 1; i >= 0; i--)
            {
                int n = int.Parse(siren[i].ToString());
                if (alternate)
                {
                    n *= 2;
                    if (n > 9)
                    {
                        n = (n % 10) + 1;
                    }
                }
                sum += n;
                alternate = !alternate;
            }

            return (sum % 10 == 0);
        }

        public bool ValidateSIREN(string siren)
        {
            throw new NotImplementedException();
        }
    }
}
