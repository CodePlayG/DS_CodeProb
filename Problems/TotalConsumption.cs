using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    class TotalConsumption
    {
        public static int Consumption(int ePurchase, int exchangeRate)
        {
            int total = 0;
            total = ePurchase + ePurchase / exchangeRate;

            int regain = ePurchase / exchangeRate + ePurchase % exchangeRate;
            if (regain > exchangeRate)
            {
                total += regain / exchangeRate;
            }
            return total;
        }
    }
}
