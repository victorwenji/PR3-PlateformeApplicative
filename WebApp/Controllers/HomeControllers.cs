using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;
using ApiEnd.Model;
using ApiEnd.Models;

namespace WebApp.Controllers
{
    public class HomeControllers :Controller
    {
        private readonly ILogger<HomeControllers> _logger;

        string baseURL = "http://localhost:5084/";

        public HomeControllers(ILogger<HomeControllers> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            //appel de l'api 
            List<Etudiant> Eleves = new List<Etudiant>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage getData = await client.GetAsync("api/Eleves");

                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;
                    Eleves = JsonConvert.DeserializeObject<List<Etudiant>>(results);

                }
                else
                {
                    Console.WriteLine("erreur calling web API");
                }

                ViewData["Eleves"] = Eleves;


            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
