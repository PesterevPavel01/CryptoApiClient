using CryptoClient.App.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoClient.App.Interfaces
{
    public interface IConnector<T> where T : class
    {
        Task<List<T>> GetAllSymbols();
    }
}
