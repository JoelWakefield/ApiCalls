using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ApiCalls.Models;
using Newtonsoft.Json;

namespace ApiCalls.Data
{
    public class ApiData
    {
        static readonly HttpClient client = new HttpClient();
        static readonly string baseUrl = "https://seriouslyfundata.azurewebsites.net/api/";

        public async Task<int> GetRandomNumber()
        {
            var response = await client.GetAsync(baseUrl + "generatearandomnumber");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            return Convert.ToInt32(responseString);
        }

        public async Task<ChuckNorisFact> GetChuckNorisJoke()
        {
            var response = await client.GetAsync(baseUrl + "chucknorrisfact");
            response.EnsureSuccessStatusCode();

            var contentStream = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ChuckNorisFact>(contentStream);
        }

        public async Task<SeleucidFacts> GetSeleucidFacts()
        {
            var response = await client.GetAsync(baseUrl + "seleucids");
            response.EnsureSuccessStatusCode();

            var contentStream = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SeleucidFacts>(contentStream);
        }

        public async Task<Teacher> GetATeacher()
        {
            var response = await client.GetAsync(baseUrl + "ateacher");
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();

            using (var stringReader = new StringReader(responseContent))
            {
                var serializer = new XmlSerializer(typeof(Teacher));
                return serializer.Deserialize(stringReader) as Teacher;
            }
        }

        public async Task<List<Teacher>> GetTeachers()
        {
            var response = await client.GetAsync(baseUrl + "yourteachers");
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();

            using (var stringReader = new StringReader(responseContent))
            {
                var serializer = new XmlSerializer(typeof(List<Teacher>));
                return serializer.Deserialize(stringReader) as List<Teacher>;
            }
        }
    }
}
