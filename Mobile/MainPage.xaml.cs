using Microsoft.Maui.Controls;
using System.Text;

namespace Mobile;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }


    private void OnLoginClicked(object sender, EventArgs e)
    {
       
        string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            // Exemple de vérification basique
            if (username == "admin" && password == "123456")
            {
                // Informations d'identification correctes, effectuez une action (par exemple, naviguez vers une autre page)
                Navigation.PushAsync(new Page1());
            }
            else
            {
                // Informations d'identification incorrectes, affichez un message d'erreur
                DisplayAlert("Erreur de connexion", "Nom d'utilisateur ou mot de passe incorrect", "OK");
            }
        }
    }

