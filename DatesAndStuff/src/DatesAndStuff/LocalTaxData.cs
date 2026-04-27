namespace DatesAndStuff;

public class LocalTaxData(string UAT)
{
    /// <summary>
    /// Administrative territorial unit identifier.
    /// </summary>
    public string UAT { get; private set; } = UAT;

    public List<TaxItem> TaxItems { get; set; } = [];

    public double DiscountPercentage { get; set; }

    public static double YearlyTax
    {
        get
        {
            return 0;
        }
    }
}