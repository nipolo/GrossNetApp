namespace GrossNetApp.Sellary.Taxes
{
    public interface ITaxRule
    {
        decimal Calculate(decimal amount);
    }
}
