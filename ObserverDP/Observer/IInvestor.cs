using ObserverDP.Subject;

namespace ObserverDP.Observer
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }

}