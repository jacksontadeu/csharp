using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocateCar.Services
{
    public class BrasilTaxService
    {
        public double Tax(double amount)
        {
            if (amount < 100)
                return 0.15 * amount;

            if (amount < 500)
                return 0.12 * amount;

            return 0.8 * amount;
        }
    }
}
