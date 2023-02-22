using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChatGptAPI.Controllers
{
    [Controller]
    [Route("api/english-tutor")]
    public class EnglishTutorController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public EnglishTutorController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string text, [FromServices] IConfiguration configuration)
        {

        }
    }
}
