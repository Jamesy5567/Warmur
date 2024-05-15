using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Warmur.Models;

namespace Warmur.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class IndicatorApiController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public IndicatorApiController(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public IActionResult GetIndicator()
        {
            var indicators = new List<Indicator>();

            return Ok(indicators);
        }
    }
}