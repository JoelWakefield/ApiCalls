using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using ApiCalls.Models;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.IO;
using ApiCalls.Data;

namespace ApiCalls.Controllers
{
    public class ApiCallerController : Controller
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string baseUrl = "https://seriouslyfundata.azurewebsites.net/api/";

        private ApiData _apiData;

        public ApiCallerController(ApiData apiData)
        {
            _apiData = apiData;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> RandomNumber()
        {
            return View(await _apiData.GetRandomNumber());
        }

        public async Task<IActionResult> ChuckNoris()
        {
            return View(await _apiData.GetChuckNorisJoke());
        }

        public async Task<IActionResult> Seleucids()
        {
            return View(await _apiData.GetSeleucidFacts());
        }

        public async Task<IActionResult> Teacher()
        {
            return View(await _apiData.GetATeacher());
        }

        public async Task<IActionResult> Teachers()
        {
            return View(await _apiData.GetTeachers());
        }
    }
}
