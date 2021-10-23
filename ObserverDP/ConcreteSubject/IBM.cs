using ObserverDP.Subject;

namespace ObserverDP.ConcreteSubject
{
    class IBM : Stock
    {
        // Constructor
        public IBM(string symbol, double price)
            : base(symbol, price)
        {
        }
    }
}