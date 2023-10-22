using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Strategy.Business;

public class ShoppingCart
{
    private IPaymentStrategy creditCartPayment = new CreditCardPayment();
    private IPaymentStrategy paypalPayment = new PayPalPayment();

    public void Checkout(double totalAmount)
    {
        //Logic
        if (totalAmount < 100)
            paypalPayment.ProcessPayment(totalAmount);
        else if (totalAmount < 100)
            creditCartPayment.ProcessPayment(totalAmount);
    }
}
