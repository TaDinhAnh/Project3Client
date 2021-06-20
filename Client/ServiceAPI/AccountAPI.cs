
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Client.Models;
using Newtonsoft.Json;

namespace Client.ServiceAPI
{
    public class AccountAPI : IAccountAPI
    {
        private string BASE_URL = "http://localhost:5000/api/account/";
        public List<Account> findAll()
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
                    return JsonConvert.DeserializeObject<List<Account>>(res);

                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public Account login(Account account)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = http.PostAsJsonAsync("login", account).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<Account>(res);

                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public List<Account> Del(int idAcc)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = http.DeleteAsync("del/" + idAcc).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<Account>>(res);

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
