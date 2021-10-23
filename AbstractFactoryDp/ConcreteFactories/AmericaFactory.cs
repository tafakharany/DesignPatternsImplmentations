using AbstractFactoryDp.AbstractFactory;
using AbstractFactoryDp.AbstractProduct;
using AbstractFactoryDp.Products;

namespace AbstractFactoryDp.ConcreteFactories
{
    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}