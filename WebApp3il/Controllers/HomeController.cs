using ApiEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;
using WebApp3il.Models;

namespace WebApp3il.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        string baseURL = "https://localhost:7219/";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            List<Etudiant> Etudiants = new List<Etudiant>();
            List<Groupe> Groupes = new List<Groupe>();
            List<Promotion> Promotions = new List<Promotion>();
            List<Presence> Presences = new List<Presence>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage getData1 = await client.GetAsync("api/Etudiants");
                HttpResponseMessage getData2 = await client.GetAsync("api/Groupes");
                HttpResponseMessage getData3 = await client.GetAsync("api/Promotions");
                HttpResponseMessage getData4 = await client.GetAsync("api/Presences");

                if (getData1.IsSuccessStatusCode)
                {
                    string results1 = getData1.Content.ReadAsStringAsync().Result;
                    Etudiants = JsonConvert.DeserializeObject<List<Etudiant>>(results1);

                    string results2 = getData2.Content.ReadAsStringAsync().Result;
                    Groupes = JsonConvert.DeserializeObject<List<Groupe>>(results2);

                    string results3 = getData3.Content.ReadAsStringAsync().Result;
                    Promotions = JsonConvert.DeserializeObject<List<Promotion>>(results3);

                    string results4 = getData4.Content.ReadAsStringAsync().Result;
                    Presences = JsonConvert.DeserializeObject<List<Presence>>(results4);
                }
                else
                {
                    Console.WriteLine("erreur calling web API");
                }

                ViewData["Etudiant"] = Etudiants;
                ViewData["Groupe"] = Groupes;
                ViewData["Promotion"] = Promotions;
                ViewData["Presence"] = Presences;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> PresenceAsync()
        {
            List<Presence> Presences = new List<Presence>();
            List<Etudiant> Etudiants = new List<Etudiant>();


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage getData = await client.GetAsync("api/Presences");
                HttpResponseMessage getData1 = await client.GetAsync("api/Etudiants");


                if (getData.IsSuccessStatusCode)
                {

                    string results = getData.Content.ReadAsStringAsync().Result;
                    Presences = JsonConvert.DeserializeObject<List<Presence>>(results);

                    string results1 = getData1.Content.ReadAsStringAsync().Result;
                    Etudiants = JsonConvert.DeserializeObject<List<Etudiant>>(results1);
                }
                else
                {
                    Console.WriteLine("erreur calling web API");
                }

                ViewData["Presence"] = Presences;
                ViewData["Etudiant"] = Etudiants;

            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}