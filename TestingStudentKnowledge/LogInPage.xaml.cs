using System;
using System.Collections.ObjectModel;
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
            ObservableCollection<Result> Results;
            Results = new ObservableCollection<Result>()
            { };
            Application.Current.Properties["results"] = Results;
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