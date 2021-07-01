using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Client.ServiceAPI
{
    public class ScoreAPI : IScoreAPI
    {
        private string BASE_URL = "http://localhost:5000/api/score/";
        public List<Score> Top(int n)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = http.GetAsync("top/" + n).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<Score>>(res);

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
