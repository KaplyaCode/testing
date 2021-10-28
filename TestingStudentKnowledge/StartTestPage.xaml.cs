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
    public partial class StartTestPage : ContentPage
    {
        public StartTestPage()
        {
            InitializeComponent();
        }

        private async void GoToMainMenu(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}