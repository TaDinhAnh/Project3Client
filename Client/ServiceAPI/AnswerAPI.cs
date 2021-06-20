using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Client.Models;
using Newtonsoft.Json;

namespace Client.ServiceAPI
{
    public class AnswerAPI : IAnswerAPI
    {
        private string BASE_URL = "http://localhost:5000/api/answer/";
        public List<Answer> findAll()
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));

                var response = http.GetAsync("findAll").Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<Answer>>(res);
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
