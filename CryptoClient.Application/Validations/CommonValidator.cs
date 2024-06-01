using CryptoClient.App.Enum;
using CryptoClient.App.Models.Result;

namespace CryptoClient.App.Validations
{
    internal class CommonValidator<T> where T : class
    {
        public SingleResult ValidateOrNull(T model)
        {
            if (model == null)
                return new SingleResult()
                {
                    ErrorMessage = ErrorMessages.ItemsNotFound,
                    ErrorCode = (int)ErrorCodes.ItemsNotFound,
                };
            return new SingleResult();
        }
    }
}
