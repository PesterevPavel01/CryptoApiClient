using CryptoClient.App.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoClient.App.Interfaces.Services
{
    public interface ICryptoApiService
    {
        Task<List<SymbolItem>> GetBybitSymbol(string Symbol);
        Task<List<SymbolItem>> GetBinanceSymbol(string symbol);
        Task<List<SymbolItem>> GetKucoinSymbol(string symbol);
        Task<List<SymbolItem>> GetBitgetSymbol(string symbol);
        Task<String[]> GetSymbols();
    }
}
