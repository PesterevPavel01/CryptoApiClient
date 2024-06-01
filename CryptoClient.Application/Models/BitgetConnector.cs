using Bitget.Net.Clients;
using CryptoClient.App.Dto;
using CryptoClient.App.Interfaces;

namespace CryptoClient.App.Models
{
    public class BitgetConnector : IConnector<SymbolItem>
    {

        public List<SymbolItem> bitgetItems;
        public BitgetConnector() { }

        public async Task<List<SymbolItem>> GetAllSymbols()
        {
            using var client = new BitgetRestClient();

            var result = await client.SpotApi.ExchangeData.GetTickersAsync();

            if (result.Success)
                return bitgetItems = new List<SymbolItem>(result.Data.Select(r => new SymbolItem(r.Symbol, r.ClosePrice)).ToList());
            else
                return new();
        }

    }
}
