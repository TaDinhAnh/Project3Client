using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Client.Models;
using Newtonsoft.Json;

namespace Client.ServiceAPI
{
    public class SerminarAPI : ISeminarAPI
    {
        private string BASE_URL = "http://localhost:5000/api/seminar/";
        public List<Seminar> findResent()
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));

                var response = http.GetAsync("findRecent").Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<Seminar>>(res);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
