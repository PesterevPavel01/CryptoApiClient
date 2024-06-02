using Bitget.Net.Clients;
using CryptoClient.App.Dto;
using CryptoClient.App.Interfaces;
using CryptoClient.App.Models.Result;

namespace CryptoClient.App.Models
{
    public class BitgetConnector : IConnector<SymbolItem>
    {
        public SymbolItem SymbolItemFromStream { get; set; }
        public async Task<List<SymbolItem>> GetAllSymbols()
        {
            using var client = new BitgetRestClient();

            var result = await client.SpotApi.ExchangeData.GetTickersAsync();

            if (result.Success)
                return new List<SymbolItem>(result.Data.Select(r => new SymbolItem(r.Symbol, r.ClosePrice)).ToList());
            else
                return [];
        }

        public async Task<SymbolItem> GetPriceBySymbol(String symbol)
        {
            return null;
        }

        public Task<SingleResult<SymbolItem>> SubscribeTradeStream(string symbol)
        {
            return null;
        }

        public Task UnsubscribeCurrentTradeStream()
        {
            return null;
        }
    }
}
