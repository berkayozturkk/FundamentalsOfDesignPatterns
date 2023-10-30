using TemplateMethod.Business;

Coffee coffee = new Coffee();
Tea tea = new Tea();

Console.WriteLine("Making coffee:");
coffee.PrepareCoffee();

Console.WriteLine("\nMaking tea:");
tea.PrepareCoffee();