using CryptoClient.App.Dto;
using CryptoClient.App.Interfaces.Services;
using CryptoClient.App.Models;
using CryptoClient.App.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoClient.App.Services
{
    public class CriptoApiService:ICryptoApiService
    {
        private readonly CommonService<BinanceConnector> binanceService;
        private readonly CommonService<BybitConnector> bybitService;
        private readonly CommonService<KucoinConnector> kucoinService;
        private readonly CommonService<BitgetConnector> bitgetService;


        public CriptoApiService() {
            bybitService = new();
            kucoinService = new();
            bitgetService = new();
            binanceService = new();
        }

        public async Task<List<SymbolItem>> GetBybitSymbol(string symbol) {
            return await GetSymbol(symbol, bybitService);
        }

        public async Task<List<SymbolItem>> GetBinanceSymbol(string symbol)
        {
            return await GetSymbol(symbol, binanceService);
        }

        public async Task<List<SymbolItem>> GetKucoinSymbol(string symbol)
        {
            return await GetSymbol(symbol, kucoinService);
        }

        public async Task<List<SymbolItem>> GetBitgetSymbol(string symbol)
        {
            return await GetSymbol(symbol, bitgetService);
        }

        private async Task<List<SymbolItem>> GetSymbol(string symbol, ICommonService<SymbolItem> service)
        {

            SingleResult<SymbolItem> result = await service.GetBySymbolAsync(symbol);

            if (result.IsSuccess)
            {
                return new List<SymbolItem> { result.Data };
            }
            else
            {
                return(new());
            }
        }

        public async Task<String[]> GetSymbols()
        {
            CollectionResult<SymbolItem> binanceItems = await binanceService.GetAllSymbolsAsync();

            List<SymbolItem> resultList = (List<SymbolItem>)binanceItems.Data;

            CollectionResult<SymbolItem> bybitItems = await bybitService.GetAllSymbolsAsync();
            resultList.AddRange((List<SymbolItem>)bybitItems.Data);

            CollectionResult<SymbolItem> kucoinItems = await kucoinService.GetAllSymbolsAsync();
            resultList.AddRange((List<SymbolItem>)kucoinItems.Data);

            CollectionResult<SymbolItem> bitgetItems = await bitgetService.GetAllSymbolsAsync();
            resultList.AddRange((List<SymbolItem>)bitgetItems.Data);

            return resultList.GroupBy(r => r.symbol).Select(r => r.First().symbol).ToArray();
        }


    }
}
