using CryptoClient.App.Dto;
using CryptoClient.App.Models.Result;

namespace CryptoClient.App.Interfaces.Services
{
    public interface ICryptoApiService
    {
        Task<List<SymbolItem>> GetBybitSymbol(string Symbol);
        Task<List<SymbolItem>> GetBinanceSymbol(string symbol);
        Task<List<SymbolItem>> GetKucoinSymbol(string symbol);
        Task<List<SymbolItem>> GetBitgetSymbol(string symbol);
        Task<string[]> GetSymbols();

        Task<SingleResult<SymbolItem>> BinanceSubscribeTradeStream(string symbol);
        List<SymbolItem> BinanceGetStreamResult();
        Task<SingleResult<SymbolItem>> BinanceStreamChangeSymbol(string symbol);

        List<SymbolItem> BybitGetStreamResult();
        Task<SingleResult<SymbolItem>> BybitSubscribeTradeStream(string symbol);
        Task<SingleResult<SymbolItem>> BybitStreamChangeSymbol(string symbol);
    }
}
