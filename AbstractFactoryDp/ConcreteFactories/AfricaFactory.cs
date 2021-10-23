
using AbstractFactoryDp.AbstractFactory;
using AbstractFactoryDp.AbstractProduct;
using AbstractFactoryDp.Products;

namespace AbstractFactoryDp.ConcreteFactories
{
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
