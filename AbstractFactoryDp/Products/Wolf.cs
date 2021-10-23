using System;
using AbstractFactoryDp.AbstractProduct;

namespace AbstractFactoryDp.Products
{
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            Console.WriteLine(this.GetType().Name +
            " eats " + h.GetType().Name);
        }
    }
}