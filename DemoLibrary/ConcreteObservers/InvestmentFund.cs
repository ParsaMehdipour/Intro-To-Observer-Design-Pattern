using DemoLibrary.ObserverInterfaces;

namespace DemoLibrary.ConcreteObservers;

/// <summary>
/// Concrete observer: Investment Fund
/// </summary>
public class InvestmentFund : IInvestor
{
    public string Name { get; }
    private decimal _portfolioValue;

    public InvestmentFund(string name, decimal initialPortfolioValue)
    {
        Name = name;
        _portfolioValue = initialPortfolioValue;
    }

    public void Update(StockData stockData)
    {
        Console.WriteLine($"Investment Fund {Name} received update for {stockData.Symbol}:");
        Console.WriteLine($"Current Price: {stockData.Price:C}");
        Console.WriteLine($"Analyzing impact on {_portfolioValue:C} portfolio...");
    }
}