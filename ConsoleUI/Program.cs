// Create the stock exchange
using DemoLibrary.ConcreteObservers;
using DemoLibrary.ConcretePublishers;

var stockExchange = new StockExchange();

// Add some stocks
stockExchange.AddStock("AAPL", 150.00m);
stockExchange.AddStock("GOOGL", 2800.00m);

// Create investors
var individualInvestor = new IndividualInvestor("John Doe", 5.00m);
var investmentFund = new InvestmentFund("Growth Fund", 1000000.00m);

// Subscribe investors to stock updates
stockExchange.Subscribe("AAPL", individualInvestor);
stockExchange.Subscribe("AAPL", investmentFund);
stockExchange.Subscribe("GOOGL", investmentFund);

// Simulate some stock price changes
stockExchange.UpdateStockPrice("AAPL", 152.50m);
stockExchange.UpdateStockPrice("GOOGL", 2850.00m);

// Unsubscribe an investor
stockExchange.Unsubscribe("AAPL", individualInvestor);

// Another price change
stockExchange.UpdateStockPrice("AAPL", 153.75m);