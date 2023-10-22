namespace Strategy.Business;

public interface IPaymentStrategy
{
    void ProcessPayment(double amount);
}
