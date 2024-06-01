using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoClient.App.Models.Result
{
    public class CollectionResult<T> : SingleResult<IEnumerable<T>>
    {
        public int Count { get; set; }

    }
}
