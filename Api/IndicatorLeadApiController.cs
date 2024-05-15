using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Warmur.Models;
using Microsoft.Extensions.Configuration;

namespace Warmur.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class IndicatorLeadApiController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public IndicatorLeadApiController(HttpClient client, IConfiguration configuration)
        {
            _httpClient = client;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetIndicatorLead()
        {
            var clientSecret = _configuration["ClientSecret"];
            var accessToken = Guid.NewGuid().ToString();

            return Ok();
        }
    }
}