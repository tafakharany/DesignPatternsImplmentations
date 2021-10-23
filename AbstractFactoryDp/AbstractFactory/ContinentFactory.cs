using AbstractFactoryDp.AbstractProduct;

namespace AbstractFactoryDp.AbstractFactory
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
