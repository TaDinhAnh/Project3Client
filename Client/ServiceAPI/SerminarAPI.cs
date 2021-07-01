using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Client.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;
using Client.DTO;
namespace Client.ServiceAPI
{
    public class SerminarAPI : ISeminarAPI
    {
        private string BASE_URL = "http://localhost:5000/api/seminar/";

        public List<SeminarDTO> findAll2()
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                var response = http.GetAsync("findAll2").Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<SeminarDTO>>(res);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public List<SeminarDTO> findResent(int n)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));

                var response = http.GetAsync("findRecent/" + n).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<SeminarDTO>>(res);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public string Create(SeminarDTO seminarDTO)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));

                var response = http.PostAsJsonAsync("create", seminarDTO).Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                return "fails";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<SeminarDTO> Del(int idSeminar)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                var response = http.DeleteAsync("del/" + idSeminar).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<SeminarDTO>>(res);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public Seminar Find(int idSeminar)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                var response = http.GetAsync("find/" + idSeminar).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<Seminar>(res);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public Seminar updatePre(int idSeminar, string idPre)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                var response = http.GetAsync("UpdatePre/" + idSeminar + "/" + idPre).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<Seminar>(res);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public string update(SeminarDTO seminarDTO)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                var response = http.PutAsJsonAsync("update/", seminarDTO).Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;

                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public Seminar delPerforment(int idSeminar, int idPerforment)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                var response = http.GetAsync("delPer/" + idSeminar + "/" + idPerforment).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<Seminar>(res);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public Seminar AddPerforment(PerformenSeminar performenSeminar)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
                var response = http.PostAsJsonAsync("addperforment", performenSeminar).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<Seminar>(res);

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
