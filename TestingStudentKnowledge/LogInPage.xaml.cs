using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestingStudentKnowledge
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
            logInButton.Clicked += GoToMainMenu;
        }

        private void logInButton_Clicked(object sender, EventArgs e)
        {
        }

        private async void GoToMainMenu(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            await Navigation.PushAsync(mainMenu);
        }
    }
}