using Mobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Services
{
    public class LoginService : ILoginRepo
    {
        public async Task<Etudiant> Login(string email)
        {
            try
            {
                if(Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
                {
                    var etudiant = new Etudiant();
                    var  client = new HttpClient();
                    string url = "";
                    client.BaseAddress = new Uri(url);
                    HttpResponseMessage response = await client.GetAsync("");
                    if(response.IsSuccessStatusCode)
                    {
                        etudiant = await response.Content.ReadFromJsonAsync<Etudiant>();
                        return await Task.FromResult(etudiant);
                    }
                    else
                    {

                    }
                   
                }
            }
            catch { }
            throw new NotImplementedException();
        }
    }
}
