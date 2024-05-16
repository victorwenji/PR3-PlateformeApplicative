using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Mobile.Models;
using Mobile.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mobile.ViewModels
{
    public partial class Login : BaseViewModel
    {
        [ObservableProperty]
        private string _email;

        readonly ILoginRepo _repo = new LoginService();

        [ICommand]
        public async void FLogin()
        {
            if(!string.IsNullOrEmpty(_email))
            {
                Etudiant etudiant = await _repo.Login(Email);
                if(Preferences.ContainsKey(nameof(App.Etudiant)))
                {
                    Preferences.Remove(nameof(App.Etudiant));
                }

                string userDetails = JsonConvert.SerializeObject(etudiant);
                Preferences.Set(nameof(App.Etudiant), userDetails);
                App.Etudiant = etudiant;

                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
        }
    }
}
