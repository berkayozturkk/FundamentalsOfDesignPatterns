using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Business;

abstract class CoffeeTemplate
{
    public void PrepareCoffee()
    {
        BoilWater();
        BrewCoffeeGrinds();
        PourInCup();
        AddCondiments();
    }

    public abstract void BrewCoffeeGrinds();
    public abstract void AddCondiments();

    public void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    public void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }
}
