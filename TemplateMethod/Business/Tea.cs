namespace TemplateMethod.Business;

class Tea : CoffeeTemplate
{
    public override void BrewCoffeeGrinds()
    {
        Console.WriteLine("Steeping the tea");
    }

    public override void AddCondiments()
    {
        Console.WriteLine("Adding Lemon");
    }
}
