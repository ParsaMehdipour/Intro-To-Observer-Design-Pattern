namespace DemoLibrary.ObserverInterfaces;

/// <summary>
/// Observer interface
/// </summary>
public interface IInvestor
{
    string Name { get; }
    void Update(StockData stockData);
}
