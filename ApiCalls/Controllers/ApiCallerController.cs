using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using ApiCalls.Models;
using Newtonsoft.Json;

namespace ApiCalls.Controllers
{
    public class ApiCallerController : Controller
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string baseUrl = "https://seriouslyfundata.azurewebsites.net/api/";

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> RandomNumber()
        {
            var response = await client.GetAsync(baseUrl + "generatearandomnumber");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            return View(Convert.ToInt32(responseString));
        }

        public async Task<IActionResult> ChuckNoris()
        {
            var response = await client.GetAsync(baseUrl + "chucknorrisfact");
            response.EnsureSuccessStatusCode();

            var contentStream = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<ChuckNorisFact>(contentStream);

            return View(content);
        }

        public async Task<IActionResult> Seleucids()
        {
            var response = await client.GetAsync(baseUrl + "seleucids");
            response.EnsureSuccessStatusCode();

            var contentStream = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<SeleucidFacts>(contentStream);

            return View(content);
        }
    }
}
