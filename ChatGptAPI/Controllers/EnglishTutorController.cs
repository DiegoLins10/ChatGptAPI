using ChatGptAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
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

        //api/english-tutor?text=
        [HttpGet]
        public async Task<IActionResult> Get(string text, [FromServices] IConfiguration configuration)
        {
            var token = configuration.GetValue<string>("ChatGptSecretKey");

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var model = new ChatGptInputModel(text);

            var requestBody = JsonSerializer.Serialize(model);

            var content = new StringContent(requestBody, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://api.openai.com/v1/completions", content);

            var result = await response.Content.ReadFromJsonAsync<ChatGptViewModel>();

            var promptResponse = result.choices.FirstOrDefault();

            return Ok(promptResponse.text.Replace("\n", "").Replace("\t", ""));
        }
    }
}
