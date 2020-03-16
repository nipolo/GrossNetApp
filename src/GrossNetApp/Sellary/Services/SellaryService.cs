using System.Linq;

using GrossNetApp.Sellary.Taxes;

namespace GrossNetApp.Sellary.Services
{
    public class SellaryService : ISellaryService
    {
        public ITaxRule[] Taxes { get; }

        public SellaryService(ITaxRule[] taxes)
        {
            Taxes = taxes;
        }

        public decimal CalculateNetPayment(decimal amount)
        {
            return amount - Taxes.Aggregate(0m, (allTaxes, next) => allTaxes + next.Calculate(amount));
        }
    }
}
