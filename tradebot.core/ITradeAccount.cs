using System.Threading.Tasks;

namespace tradebot.core
{
    public interface ITradeAccount
    {
        // Read-only properties which is return the value of TradeCoin
        decimal CurrentAskPrice { get; }
        decimal CurrentBidPrice { get; }
        decimal CurrentBidQty { get; }
        decimal CurrentAskQty { get; }

        decimal TradingFee { get; set; }
        Coin Bitcoin { get; set; }
        Coin TradeCoin { get; set; }
        Task UpdatePrices();
        Task<TradeBotApiResult> UpdateBalances();
        Task<TradeBotApiResult> Buy(string trans, decimal quantity, decimal price);
        Task<TradeBotApiResult> Sell(string trans, decimal quantity, decimal price);
        Task<bool> IsOrderMatched();
    }
}