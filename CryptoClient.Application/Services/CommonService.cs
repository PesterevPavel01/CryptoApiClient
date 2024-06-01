using CryptoClient.App.Dto;
using CryptoClient.App.Enum;
using CryptoClient.App.Interfaces;
using CryptoClient.App.Interfaces.Services;
using CryptoClient.App.Models.Result;
using CryptoClient.App.Validations;

namespace CryptoClient.App.Services
{
    public class CommonService<T> : ICommonService<SymbolItem> where T : IConnector<SymbolItem>, new()
    {
        private readonly  T  _connector;
        private readonly CommonValidator<SymbolItem> _validator;

        public CommonService()
        {
            _connector = new ();
            _validator = new ();
        }

        public async Task<CollectionResult<SymbolItem>> GetAllSymbolsAsync()
        {
            List<SymbolItem> items = await _connector.GetAllSymbols();
            if (!items.Any())
            {
                return new CollectionResult<SymbolItem>()
                {
                    ErrorMessage = ErrorMessages.ItemsNotFound,
                    ErrorCode = (int)ErrorCodes.ItemsNotFound
                };
            }
            return new CollectionResult<SymbolItem>()
            {
                Data = items,
                Count = items.Count()
            };
        }

        public async Task<SingleResult<SymbolItem>> GetBySymbolAsync(string symbol)
        {
            CollectionResult<SymbolItem> items = await GetAllSymbolsAsync();

            if (!items.IsSuccess)
                return new SingleResult<SymbolItem>()
                {
                    ErrorMessage = ErrorMessages.ItemsNotFound,
                    ErrorCode = (int)ErrorCodes.ItemsNotFound
                };

            SymbolItem item = items.Data.FirstOrDefault(x => x.symbol == symbol);

            var result = _validator.ValidateOrNull(item);

            if (!result.IsSuccess)
                return new SingleResult<SymbolItem>()
                {
                    ErrorMessage = ErrorMessages.ItemNotFound,
                    ErrorCode = (int)ErrorCodes.ItemNotFound
                };

            return new SingleResult<SymbolItem>()
            {
                Data = item
            };
        }
    }
}
