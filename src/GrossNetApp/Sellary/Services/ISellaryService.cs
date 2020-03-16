using GrossNetApp.Sellary.Taxes;

namespace GrossNetApp.Sellary.Services
{
    public interface ISellaryService
    {
        ITaxRule[] Taxes { get; }

        decimal CalculateNetPayment(decimal amount);
    }
}
