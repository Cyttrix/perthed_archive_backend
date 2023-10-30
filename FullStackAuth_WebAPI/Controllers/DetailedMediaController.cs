using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.DataTransferObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailedMediaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public DetailedMediaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET api/<DetailedMediaController>/<id>
        [HttpGet("{id}")]
        public IActionResult GetMediaById(string id)
        {
            try
            {
                HttpClient client = new HttpClient();
                var moviesExtendedEndPointUrl = "https://api4.thetvdb.com/v4/movies/";
                var extended = "/extended";

                string token = "";

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = client.GetAsync(moviesExtendedEndPointUrl + id + extended).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var jsonDoc = JsonDocument.Parse(responseBody);
                var dataElement = jsonDoc.RootElement.GetProperty("data");
                var results = JsonSerializer.Deserialize<MediaForDetailsPageDto>(dataElement.GetRawText(), options);

                return StatusCode(200, results);

            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
