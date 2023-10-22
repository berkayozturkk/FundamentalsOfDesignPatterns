namespace Strategy.Business;

// PayPal ödeme stratejisi
class PayPalPayment : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"A payment of ${amount} has been made with PayPal.");
    }
}
