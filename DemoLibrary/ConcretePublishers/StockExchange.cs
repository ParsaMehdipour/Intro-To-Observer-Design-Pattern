using DemoLibrary.BasePublishers;

namespace DemoLibrary.ConcretePublishers;

/// <summary>
/// Concrete publisher with business logic
/// </summary>
public class StockExchange : StockMarket
{
    private Dictionary<string, StockData> _stocks = new Dictionary<string, StockData>();

    public void AddStock(string symbol, decimal initialPrice)
    {
        _stocks[symbol] = new StockData(symbol, initialPrice, DateTime.Now);
    }

    public void UpdateStockPrice(string symbol, decimal newPrice)
    {
        if (_stocks.ContainsKey(symbol))
        {
            var oldPrice = _stocks[symbol].Price;
            _stocks[symbol] = new StockData(symbol, newPrice, DateTime.Now);
            Console.WriteLine($"\nStock price updated: {symbol} from {oldPrice:C} to {newPrice:C}");
            NotifyObservers(symbol, _stocks[symbol]);
        }
    }
}

