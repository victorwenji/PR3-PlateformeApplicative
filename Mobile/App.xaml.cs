using Mobile.Models;

namespace Mobile
{
    public partial class App : Application
    {
        public static Etudiant Etudiant;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}