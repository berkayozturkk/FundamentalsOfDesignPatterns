namespace TemplateMethod.Business;

class Coffee : CoffeeTemplate
{
    public override void BrewCoffeeGrinds()
    {
        Console.WriteLine("Dripping Coffee through filter");
    }

    public override void AddCondiments()
    {
        Console.WriteLine("Adding Sugar and Milk");
    }
}
