using DemoLibrary.ObserverInterfaces;

namespace DemoLibrary.BasePublishers;

/// <summary>
/// The base publisher class that manages subscriptions and notifications
/// </summary>
public class StockMarket
{
    private Dictionary<string, List<IInvestor>> _observers = new Dictionary<string, List<IInvestor>>();

    public void Subscribe(string stockSymbol, IInvestor investor)
    {
        if (!_observers.ContainsKey(stockSymbol))
        {
            _observers[stockSymbol] = new List<IInvestor>();
        }
        _observers[stockSymbol].Add(investor);
        Console.WriteLine($"{investor.Name} subscribed to {stockSymbol} stock updates");
    }

    public void Unsubscribe(string stockSymbol, IInvestor investor)
    {
        if (_observers.ContainsKey(stockSymbol))
        {
            _observers[stockSymbol].Remove(investor);
            Console.WriteLine($"{investor.Name} unsubscribed from {stockSymbol} stock updates");
        }
    }

    protected void NotifyObservers(string stockSymbol, StockData stockData)
    {
        if (_observers.ContainsKey(stockSymbol))
        {
            foreach (var investor in _observers[stockSymbol])
            {
                investor.Update(stockData);
            }
        }
    }
}