using Binance.Net.Clients;
using Bybit.Net.Clients;
using CryptoClient.App.Dto;
using CryptoClient.App.Interfaces;
using CryptoClient.App.Models.Result;
using Kucoin.Net.Clients;

namespace CryptoClient.App.Models
{
    public class KucoinConnector : IConnector<SymbolItem>
    {
        public SymbolItem SymbolItemFromStream { get; set; }
        public async Task<List<SymbolItem>> GetAllSymbols()
        {
            var client = new KucoinRestClient();
            var result = await client.SpotApi.ExchangeData.GetTickersAsync();

            if (result.Success)
                return new List<SymbolItem>(result.Data.Data.Select(r => new SymbolItem(r.SymbolName.Replace("-",""), Convert.ToDecimal(r.LastPrice))).ToList());
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
