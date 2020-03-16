using System;

namespace GrossNetApp.Sellary.Taxes
{
    public class IncomeTax : ITaxRule
    {
        public decimal Calculate(decimal amount)
        {
            return Math.Max(amount - 1000m, 0m) * 0.1m;
        }
    }
}
