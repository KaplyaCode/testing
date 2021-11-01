using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace TestingStudentKnowledge
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
            TurnOnNextButton();

            localPath = Path.Combine(FileSystem.CacheDirectory);
            questionLabel.Text = GroupQuestions[currentQuestion].question;
            QuestList.ItemsSource = GroupQuestions[currentQuestion].Answers;
            
        }

        const string resultsFileName = "ResultsFile.txt";
        string localPath;

        public List<Question> GroupQuestions = (List<Question>)Application.Current.Properties["groupQuestions"];
        public User currentUser = (User)Application.Current.Properties["currentUser"];

        public int currentQuestion = 0;

        public void nextQuestion(object sender, EventArgs e)
        {
            int questionCount = GroupQuestions.Count() - 1;

            if (currentQuestion < questionCount)
            {
                TurnOnNextButton();
                if (GroupQuestions[currentQuestion].Answers.IndexOf(QuestList.SelectedItem) == GroupQuestions[currentQuestion].correctAnswer)
                {
                    DisplayAlert("Правильна відповідь!", "Ваша відповідь: " + GroupQuestions[currentQuestion].Answers.IndexOf(QuestList.SelectedItem + "") + "\nПравильна відповідь: " + GroupQuestions[currentQuestion].correctAnswer, "ok");
                    currentUser.score += currentUser.weigth;
                } else
                {
                    DisplayAlert("Неправильна відповідь!", "Ваша відповідь: " + GroupQuestions[currentQuestion].Answers.IndexOf(QuestList.SelectedItem + "") + "\nПравильна відповідь: " + GroupQuestions[currentQuestion].correctAnswer, "ok");
                }
                currentQuestion++;
                questionLabel.Text = GroupQuestions[currentQuestion].question;
                QuestList.ItemsSource = GroupQuestions[currentQuestion].Answers;
            }
            else if (currentQuestion == questionCount)
            {
                DisplayAlert("Результат!", "Рахунок: " + currentUser.score + "/" + currentUser.weigth * 5, "ok");
                TurnOnMainMenuButton();
                //Save();
                currentUser.score = 0;
            }
        }

        private async void GoToMainMenu(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void TurnOnMainMenuButton()
        {
            next.IsEnabled = false;
            next.IsVisible = false;
            mainMenuButton.IsEnabled = true;
            mainMenuButton.IsVisible = true;
        }

        private void TurnOnNextButton()
        {
            mainMenuButton.IsEnabled = false;
            mainMenuButton.IsVisible = false;
            next.IsEnabled = true;
            next.IsVisible = true;
        }

        public string ResultTostring()
        {
            StringBuilder resultString = new StringBuilder();
            resultString.Append(currentUser.surname 
                + " " + GroupQuestions[currentQuestion].Facult 
                + " " + currentUser.score);
            return resultString.ToString();
        }

        private void Save()
        {
            File.WriteAllText(resultsFileName, ResultTostring());
        }
    }
}