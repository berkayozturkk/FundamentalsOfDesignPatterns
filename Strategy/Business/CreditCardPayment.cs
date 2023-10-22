namespace Strategy.Business;

class CreditCardPayment : IPaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"A payment of ${amount} has been made with a credit card.");
    }
}
