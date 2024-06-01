using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoClient.App.Dto
{
    public class SymbolItem
    {
        public SymbolItem(string symbol, decimal price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public string symbol { get; set; }

        public decimal price { get; set; }
    }
}
