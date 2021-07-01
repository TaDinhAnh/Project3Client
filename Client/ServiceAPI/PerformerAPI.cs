using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Client.ServiceAPI
{
    public class PerformerAPI : IPerformerAPI
    {
        private string BASE_URL = "http://localhost:5000/api/performer/";

        public List<Performer> Find2(int idSeminar)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                var response = http.GetAsync("find2/" + idSeminar).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<Performer>>(res);
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
