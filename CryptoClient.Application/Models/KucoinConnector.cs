using CryptoClient.App.Dto;
using CryptoClient.App.Interfaces;
using CryptoExchange.Net.Interfaces;
using Kucoin.Net.Clients;

namespace CryptoClient.App.Models
{
    public class KucoinConnector : IConnector<SymbolItem>
    {
        public List<SymbolItem> kucoinItems;
        public KucoinConnector() { }

        public async Task<List<SymbolItem>> GetAllSymbols()
        {
            var client = new KucoinRestClient();
            var result = await client.SpotApi.ExchangeData.GetTickersAsync();

            if (result.Success)
                return kucoinItems = new List<SymbolItem>(result.Data.Data.Select(r => new SymbolItem(r.Symbol, Convert.ToDecimal(r.LastPrice))).ToList());
            else
                return new();
        }
    }
}
