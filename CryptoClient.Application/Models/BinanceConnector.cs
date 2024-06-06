using Binance.Net.Clients;
using CryptoClient.App.Dto;
using CryptoClient.App.Enum;
using CryptoClient.App.Interfaces;
using CryptoClient.App.Models.Result;

namespace CryptoClient.App.Models
{
    public class BinanceConnector:IConnector<SymbolItem>
    {
        private readonly BinanceSocketClient socketClient;
        public SymbolItem SymbolItemFromStream { get; set; }

        public BinanceConnector()
        {
            SymbolItemFromStream = new();
            socketClient = new BinanceSocketClient();
        }
             

        public async Task<List<SymbolItem>> GetAllSymbols()
        {
            using var client = new BinanceRestClient();

            var result = await client.SpotApi.ExchangeData.GetPricesAsync();

            if (result.Success)
                return new List<SymbolItem>(result.Data.Select(r => new SymbolItem(r.Symbol, r.Price)).ToList());
            else
                return [];
        }

        public async Task<SymbolItem> GetPriceBySymbol(String symbol)
        {
            using BinanceSocketClient socketClient = new ();

            SymbolItem symbolItem = new();

            var subscribeResult = await socketClient.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync(symbol, (update) =>
               
                {
                    symbolItem.symbol= symbol;
                    symbolItem.price = update.Data.LastPrice;
                });

            return symbolItem;

        }

        public async Task<SingleResult<SymbolItem>> SubscribeTradeStream(String symbol) {

            SymbolItemFromStream = new();

            var subscription = await socketClient.SpotApi.ExchangeData.SubscribeToTradeUpdatesAsync(symbol, data =>
            {

                    SymbolItemFromStream.symbol = data.Data.Symbol;
                    SymbolItemFromStream.price = data.Data.Price;

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
