using Strategy.Business;

//Is Context.
ShoppingCart cart = new ShoppingCart();

// Credit card
cart.SetPaymentStrategy(new CreditCardPayment());
cart.Checkout(100.00);

// PayPal 
cart.SetPaymentStrategy(new PayPalPayment());
cart.Checkout(50.00);