using Bybit.Net.Clients;
using CryptoClient.App.Dto;
using CryptoClient.App.Enum;
using CryptoClient.App.Interfaces;
using CryptoClient.App.Models.Result;

namespace CryptoClient.App.Models
{
    public class BybitConnector : IConnector<SymbolItem>
    {
        private readonly BybitSocketClient socketClient;
        public SymbolItem SymbolItemFromStream { get; set; }

        public BybitConnector()
        {
            SymbolItemFromStream = new();
            socketClient = new();
        }
        public async Task<List<SymbolItem>> GetAllSymbols()
        {
            using BybitRestClient client = new();

            var result = await client.V5Api.ExchangeData.GetSpotTickersAsync();

            var resultList = result.Data.List;

            if (result.Success)
                return new List<SymbolItem>(result.Data.List.Select(r => new SymbolItem(r.Symbol, r.LastPrice)).ToList());
            else
                return [];
        }

        public async Task<SymbolItem> GetPriceBySymbol(String symbol)
        {
            using BybitSocketClient socketClient = new();

            SymbolItem symbolItem = new();

            var subscribeResult = await socketClient.V5SpotApi.SubscribeToTickerUpdatesAsync(symbol, (update) =>
            {
                symbolItem.symbol = symbol;
                symbolItem.price = update.Data.LastPrice;
            });
            return symbolItem;

        }

        public async Task<SingleResult<SymbolItem>> SubscribeTradeStream(String symbol)
        {
            
            SymbolItemFromStream = new();

            var subscription = await socketClient.V5SpotApi.SubscribeToTickerUpdatesAsync(symbol, data =>
            {

                SymbolItemFromStream.symbol = data.Data.Symbol;
                SymbolItemFromStream.price = data.Data.LastPrice;

            });


            if (subscription.Success)
            {
                return new SingleResult<SymbolItem>
                {
                    Data = SymbolItemFromStream
                };
            }

            else
            return new SingleResult<SymbolItem>
            {
                ErrorCode = (int)ErrorCodes.FailedToSubscribe,
                ErrorMessage = ErrorMessages.FiledToSubscribe,
            };
        }

        public async Task UnsubscribeCurrentTradeStream()
        {

            await socketClient.UnsubscribeAllAsync();

        }
    }
}
