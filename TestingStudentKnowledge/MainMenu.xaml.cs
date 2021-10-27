using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestingStudentKnowledge
{
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
            exitButton.Clicked += GoToLogInPage;
        }

        private void exitButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void GoToLogInPage(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
