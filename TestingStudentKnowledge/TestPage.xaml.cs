using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

            localPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
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

            if (currentQuestion < GroupQuestions.Count())
            {
                if (GroupQuestions[currentQuestion].Answers.IndexOf(QuestList.SelectedItem) == GroupQuestions[currentQuestion].correctAnswer)
                {
                    DisplayAlert("Правильна відповідь!", "Ваша відповідь: " 
                        + GroupQuestions[currentQuestion].Answers.IndexOf(QuestList.SelectedItem + "") 
                        + "\nПравильна відповідь: " + GroupQuestions[currentQuestion].correctAnswer 
                        + "\ncurrentQuestion: " + currentQuestion 
                        + "\nquestionCount" + GroupQuestions.Count(), "ok");
                    currentUser.score += currentUser.weigth;
                } 
                else
                {
                    DisplayAlert("Неправильна відповідь!", "Ваша відповідь: " 
                        + GroupQuestions[currentQuestion].Answers.IndexOf(QuestList.SelectedItem + "") 
                        + "\nПравильна відповідь: " + GroupQuestions[currentQuestion].correctAnswer 
                        + "\ncurrentQuestion: " + currentQuestion
                        + "\nquestionCount" + GroupQuestions.Count(), "ok");
                }

            }
            if (currentQuestion + 1 != GroupQuestions.Count())
            {
                questionLabel.Text = GroupQuestions[currentQuestion + 1].question;
                QuestList.ItemsSource = GroupQuestions[currentQuestion + 1].Answers;
            }
            if (currentQuestion + 1 == GroupQuestions.Count())
            {
                TurnOnMainMenuButton();
                DisplayAlert("Результат!", "Рахунок: " 
                    + currentUser.score + "/" + currentUser.weigth
                    + "\n" + Path.Combine(localPath, resultsFileName) 
                    + "\n" + ResultToString(), "ok");
                Save();
                GroupQuestions.Clear();
                currentUser.score = 0;
                currentUser.weigth = 100.0;
            }
            currentQuestion++;
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

        public string ResultToString()
        {
            StringBuilder resultString = new StringBuilder();
            resultString.Append(currentUser.surname 
                + " " + GroupQuestions[currentQuestion].Facult 
                + " " + currentUser.score);
            return resultString.ToString();
        }

        private void Save()
        {
            File.WriteAllText(Path.Combine(localPath, resultsFileName), ResultToString());
        }
    }
}