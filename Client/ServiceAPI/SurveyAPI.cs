using Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Client.ServiceAPI
{
    public class SurveyAPI : ISurveyAPI
    {
        private string BASE_URL = "http://localhost:5000/api/survey/";
        public List<Survey> FindAll()
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = http.GetAsync("findAll").Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<Survey>>(res);

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
