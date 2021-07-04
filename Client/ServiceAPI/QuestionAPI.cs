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
    public class QuestionAPI : IQuestionAPI
    {
        private string BASE_URL = "http://localhost:5000/api/question/";

        public List<Question> delQuestion(int idQuestion)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));

                var response = http.DeleteAsync("del/" + idQuestion).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<Question>>(res);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public List<Question> Create(Question question)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));

                var response = http.PostAsJsonAsync("create", question).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<List<Question>>(res);

                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public List<Question> findAll()
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
                    return JsonConvert.DeserializeObject<List<Question>>(res);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public Question DetailQuestion(int idQuestion)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));

                var response = http.GetAsync("find/" + idQuestion).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<Question>(res);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public Question Update(Question question)
        {
            try
            {
                var http = new HttpClient();
                http.BaseAddress = new Uri(BASE_URL);
                http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));

                var response = http.PutAsJsonAsync("update", question).Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<Question>(res);
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
