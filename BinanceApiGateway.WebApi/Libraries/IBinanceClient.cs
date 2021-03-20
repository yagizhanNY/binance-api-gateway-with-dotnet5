using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinanceApiGateway.WebApi.Libraries
{
    public interface IBinanceClient
    {
        Task<string> GetCurrencyAsync(string currencyName);
    }
}
