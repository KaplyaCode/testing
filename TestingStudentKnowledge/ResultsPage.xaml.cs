using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestingStudentKnowledge
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultsPage : ContentPage
    {
        protected internal ObservableCollection<Result> Results { get; set; }

        public User currentUser = (User)Application.Current.Properties["currentUser"];

        public ResultsPage()
        {
            InitializeComponent();
            Results = new ObservableCollection<Result>()
            {
                /*new Result() { Surname = "Царенок", Faculty = "Програмування", Score = 99},
                new Result() { Surname = "Капышин", Faculty = "Право", Score = 11},
                new Result() { Surname = "Самсонов", Faculty = "Менеджмент", Score = 55}*/
            };
            UpdateResults();
            resultsListView.BindingContext = Results;
            resultsListView.ItemsSource = Results;
        }

        protected internal void AddResult(Result result)
        {
            Results.Add(result);
        }

        public void RemoveResult(Result result)
        {
            Results.Remove(result);
        }

        private void UpdateResults()
        {
            if (Application.Current.Properties.ContainsKey("results"))
            {
                Results = (ObservableCollection<Result>)Application.Current.Properties["results"];
                Application.Current.Properties["results"] = null;
            }
        }
        
        private async void GoToMainMenu(object sender, EventArgs e)
        {
            Application.Current.Properties["results"] = Results;
            await Navigation.PopAsync();
        }

        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            Result selectedResult = args.SelectedItem as Result;
            if (selectedResult != null)
            {
                resultsListView.SelectedItem = null;
                if (selectedResult.Surname == currentUser.surname)
                {
                    RemoveResult(selectedResult);
                    Application.Current.Properties["results"] = Results;
                }
            }
        }
    }
}