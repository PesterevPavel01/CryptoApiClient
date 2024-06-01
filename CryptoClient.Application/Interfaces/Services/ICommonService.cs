using CryptoClient.App.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoClient.App.Interfaces.Services
{
    public interface ICommonService<T> where T : class
    {
        Task<CollectionResult<T>> GetAllSymbolsAsync();
        Task<SingleResult<T>> GetBySymbolAsync(string symbol);

    }
}
