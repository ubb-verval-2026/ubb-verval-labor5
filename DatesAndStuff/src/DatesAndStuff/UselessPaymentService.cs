namespace DatesAndStuff;

public class UselessPaymentService : IPaymentService
{
    public double Balance => Double.PositiveInfinity;

    public void ConfirmPayment()
    {
    }

    public void SpecifyAmount(double amount)
    {
    }

    public void StartPayment()
    {
    }

    public bool SuccessFul()
    {
        return true;
    }
}
