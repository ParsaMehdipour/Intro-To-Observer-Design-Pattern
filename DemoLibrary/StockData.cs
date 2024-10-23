namespace DemoLibrary;

/// <summary>
/// Data structure for stock information
/// </summary>
public class StockData
{
    public string Symbol { get; }
    public decimal Price { get; }
    public DateTime LastUpdate { get; }
    public decimal PriceChange { get; }

    public StockData(string symbol, decimal price, DateTime lastUpdate)
    {
        Symbol = symbol;
        Price = price;
        LastUpdate = lastUpdate;
    }
}