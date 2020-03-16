using System;

namespace GrossNetApp.Sellary.Taxes
{
    public class SocialContributionsTax : ITaxRule
    {
        public decimal Calculate(decimal amount)
        {
            return Math.Min(amount > 1000.0m ? amount - 1000m : 0m, 2000m) * 0.15m;
        }
    }
}
