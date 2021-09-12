using MvcFrameWork.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace Pagina.Services
{
    public class ApiServices
    {
        const string UrlBaseApi = "https://jsonplaceholder.typicode.com";

        public List<Albums> IntegrarAPIJson()
        {
            List<Albums> repositorio = new List<Albums>();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
                HttpResponseMessage response = client.GetAsync(UrlBaseApi + "/albums").Result;

                response.EnsureSuccessStatusCode();
                string conteudo = response.Content.ReadAsStringAsync().Result;

                dynamic resultado = JsonConvert.DeserializeObject(conteudo);
              
                foreach (var item in resultado)
                {
                    Albums repos = new Albums();

                    repos.UserId = item.userId;
                    repos.Id = item.id;
                    repos.Title = item.title;
                    repositorio.Add(repos);

                }

                return repositorio;
            }
        }
        public List<Posts> IntegrarAPIPosts()
        {
            List<Posts> repositorio = new List<Posts>();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
                HttpResponseMessage response = client.GetAsync(UrlBaseApi + "/posts").Result;

                response.EnsureSuccessStatusCode();
                string conteudo = response.Content.ReadAsStringAsync().Result;

                dynamic resultado = JsonConvert.DeserializeObject(conteudo);

                foreach (var item in resultado)
                {
                    Posts repos = new Posts();

                    repos.UserId = item.userId;
                    repos.Id = item.id;
                    repos.Title = item.title;
                    repositorio.Add(repos);
                }

                return repositorio;
            }
        }
        public List<Todos> IntegrarAPITodos()
        {
            List<Todos> repositorio = new List<Todos>();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
                HttpResponseMessage response = client.GetAsync(UrlBaseApi + "/todos").Result;

                response.EnsureSuccessStatusCode();
                string conteudo = response.Content.ReadAsStringAsync().Result;

                dynamic resultado = JsonConvert.DeserializeObject(conteudo);

                foreach (var item in resultado)
                {
                    Todos repos = new Todos();

                    repos.UserId = item.userId;
                    repos.Id = item.id;
                    repos.Title = item.title;
                    repos.Completed = item.completed;
                    repositorio.Add(repos);             
                }

                return repositorio;
            }
        }
    }
}
