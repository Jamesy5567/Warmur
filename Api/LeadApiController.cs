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
    public class LeadApiController : ControllerBase
    {

        private readonly HttpClient _httpClient;

        public LeadApiController(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public IActionResult GetLead()
        {
            var leads = new List<Lead>();

            return Ok(leads);
        }
    }
}