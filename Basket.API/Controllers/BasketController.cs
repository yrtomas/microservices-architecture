using Basket.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Basket.API.Controllers
{
    [ApiController]
    [Route("api/v1/basket")]
    public class BasketController : ControllerBase
    {
        private readonly ILogger<BasketController> _logger;

        private readonly ConnectionMultiplexer _redis;

        private readonly IDatabase _database;

        public BasketController(ILogger<BasketController> logger, ConnectionMultiplexer redis)
        {
            _logger = logger;

            _redis = redis;

            _database = redis.GetDatabase();
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> UpdateBasketAsync([FromBody] ItemsInBasket itemsInBasket)
        {
            var created = await _database.StringSetAsync(1.ToString(), JsonConvert.SerializeObject(itemsInBasket));

            return Ok();
        }

    }
}
