using CryptoClient.App.Dto;
using CryptoClient.App.Models.Result;

namespace CryptoClient.App.Interfaces.Services
{
    public interface ICommonService<T> where T : class
    {
        Task<CollectionResult<T>> GetAllSymbolsAsync();
        Task<SingleResult<T>> GetBySymbolAsync(string symbol);
        Task<SingleResult<SymbolItem>> TradeStreamChangeSymbol(string symbol);
        Task<SingleResult<SymbolItem>> SubscribeTradeStream(string symbol);
        Task UnsubscribeCurrentTradeStream();
        SymbolItem GetStreamResult();
    }
}
