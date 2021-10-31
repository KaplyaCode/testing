using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace TestingStudentKnowledge
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
            logInButton.Clicked += SaveUserName;
        }

        public void SaveUserName(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            string surName = surNameEntry.Text;

            Preferences.Set("name", name);
            Preferences.Set("surName", surName);
        }

        private async void GoToMainMenu(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            await Navigation.PushAsync(mainMenu);
        }
    }
}