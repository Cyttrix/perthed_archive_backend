using FullStackAuth_WebAPI.Data;
using FullStackAuth_WebAPI.DataTransferObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;
using System;
using System.Net.Http.Headers;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackAuth_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public MediaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET api/<MediaController>/<title>
        [HttpGet("{title}")]
        public IActionResult GetMediaInformation(string title)
        {
            try
            {
                  HttpClient client = new HttpClient();
                var url = "https://api4.thetvdb.com/v4/search?query=";
                var escapedTitle = Uri.EscapeDataString(title);

        string token = " ";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = client.GetAsync(url + escapedTitle).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var jsonDoc = JsonDocument.Parse(responseBody);
                var dataElement = jsonDoc.RootElement.GetProperty("data");
                var results = JsonSerializer.Deserialize<List<MediaToDisplayDto>>(dataElement.GetRawText(), options);

           


                return StatusCode(200, results);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(500, ex.Message);
            }
           
            
        }


        // PUT api/<MediaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<MediaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
