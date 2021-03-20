using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BinanceApiGateway.WebApi.Libraries
{
    public class BinanceClient : IBinanceClient
    {
        public async Task<string> GetCurrencyAsync(string currencyName)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://api.binance.com/api/v3/ticker/price?symbol={currencyName}");
            response.EnsureSuccessStatusCode();

            string data = await response.Content.ReadAsStringAsync();

            return data;
        }
    }
}
