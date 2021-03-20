using BinanceApiGateway.WebApi.Libraries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinanceApiGateway.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GatewayController : ControllerBase
    {
        IBinanceClient BinanceClient;

        public GatewayController(IBinanceClient binanceClient)
        {
            BinanceClient = binanceClient;
        }

        [HttpGet]
        [Route("get")]
        public async Task<string> GetAsync(string currencyName)
        {
            string result = await BinanceClient.GetCurrencyAsync(currencyName);

            return result;
        }
    }
}
