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
    public class AllpeopleAPI : IAllPeopleAPI
    {
        private string BASE_URL = "http://localhost:5000/api/allperson/";
        public List<AllPerson> findStaff()
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = http.GetAsync("findStaff").Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<AllPerson>>(res);

                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public AllPerson find(string idPerson)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = http.GetAsync("find/"+idPerson).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<AllPerson>(res);

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
