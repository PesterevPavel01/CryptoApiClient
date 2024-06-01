using Binance.Net.Clients;
using CryptoClient.App.Dto;
using CryptoClient.App.Interfaces;

namespace CryptoClient.App.Models
{
    public class BinanceConnector:IConnector<SymbolItem>
    {
        public List<SymbolItem> binanceItems;

        public async Task<List<SymbolItem>> GetAllSymbols()
        {
            using var client = new BinanceRestClient();

            var result = await client.SpotApi.ExchangeData.GetPricesAsync();

            if (result.Success)
                return binanceItems = new List<SymbolItem>(result.Data.Select(r => new SymbolItem(r.Symbol, r.Price)).ToList());
            else
                return new();
        }

    }
}
