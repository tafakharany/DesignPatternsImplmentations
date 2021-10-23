using System;
using AbstractFactoryDp.AbstractProduct;

namespace AbstractFactoryDp.Products
{
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name +
            " eats " + h.GetType().Name);
        }
    }
}