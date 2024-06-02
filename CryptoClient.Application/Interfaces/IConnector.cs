using CryptoClient.App.Dto;
using CryptoClient.App.Models.Result;

namespace CryptoClient.App.Interfaces
{
    public interface IConnector<T> where T : class
    {
        T SymbolItemFromStream { get; set; }
        Task<List<T>> GetAllSymbols();
        Task<SymbolItem> GetPriceBySymbol(String symbol);
        Task<SingleResult<SymbolItem>> SubscribeTradeStream(String symbol);
        Task UnsubscribeCurrentTradeStream();
    }
}
