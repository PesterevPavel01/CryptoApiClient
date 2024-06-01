using Bybit.Net.Clients;
using CryptoClient.App.Dto;
using CryptoClient.App.Interfaces;

namespace CryptoClient.App.Models
{
    public class BybitConnector : IConnector<SymbolItem>
    {
        public List<SymbolItem> bybitItems;
        public BybitConnector() { }

        public async Task<List<SymbolItem>> GetAllSymbols()
        {
            var client = new BybitRestClient();

            var result = await client.V5Api.ExchangeData.GetSpotTickersAsync();
            var x = result.Data.List;

            if (result.Success)
                return bybitItems = new List<SymbolItem>(result.Data.List.Select(r => new SymbolItem(r.Symbol, r.LastPrice)).ToList());
            else
                return new();
        }
    }
}
