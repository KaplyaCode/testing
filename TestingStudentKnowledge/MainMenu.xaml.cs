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
        }

        private async void GoToLogInPage(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void GoToResultsPage(object sender, EventArgs e)
        {
            ResultsPage resultsPage = new ResultsPage();
            await Navigation.PushAsync(resultsPage);
        }

        private async void GoToStartTestPage(object sender, EventArgs e)
        {
            StartTestPage startTestPage = new StartTestPage();
            await Navigation.PushAsync(startTestPage);
        }
    }
}
