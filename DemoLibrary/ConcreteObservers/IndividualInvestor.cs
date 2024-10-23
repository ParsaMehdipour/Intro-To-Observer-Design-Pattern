using DemoLibrary.ObserverInterfaces;

namespace DemoLibrary.ConcreteObservers;

/// <summary>
/// Concrete observer: Individual Investors
/// </summary>
public class IndividualInvestor : IInvestor
{
    public string Name { get; }
    private decimal _threshold;

    public IndividualInvestor(string name, decimal priceChangeThreshold)
    {
        Name = name;
        _threshold = priceChangeThreshold;
    }

    public void Update(StockData stockData)
    {
        Console.WriteLine($"Individual Investor {Name} received update for {stockData.Symbol}:");
        Console.WriteLine($"Current Price: {stockData.Price:C}");
        Console.WriteLine($"Last Updated: {stockData.LastUpdate}");
    }
}
