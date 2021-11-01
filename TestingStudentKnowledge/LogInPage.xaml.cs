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
        }

        public User currentUser = new User();

        private async void GoToMainMenu(object sender, EventArgs e)
        {
            currentUser.name = nameEntry.Text;
            currentUser.surname = surNameEntry.Text;

            Application.Current.Properties["currentUser"] = currentUser;

            MainMenu mainMenu = new MainMenu();
            await Navigation.PushAsync(mainMenu);
        }
    }
}