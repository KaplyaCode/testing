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
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();

            questionLabel.Text = GroupQuestions[currentQuestion].question;

            QuestList.ItemsSource = GroupQuestions[currentQuestion].Answers;
        }

        public List<Question> GroupQuestions = (List<Question>)Application.Current.Properties["groupQuestions"];
        public int currentQuestion = 0;
        public User currentUser = (User)Application.Current.Properties["currentUser"];

        public void nextQuestion(object sender, EventArgs e)
        {
            DisplayAlert("", GroupQuestions[currentQuestion].Answers.IndexOf(QuestList.SelectedItem + "") +" "+ GroupQuestions[currentQuestion].correctAnswer, "ok");

            if (currentQuestion < GroupQuestions.Count - 1)
            {
                if (GroupQuestions[currentQuestion].Answers.IndexOf(QuestList.SelectedItem + "") == GroupQuestions[currentQuestion].correctAnswer)
                    currentUser.coincidence += currentUser.weigth;

                currentQuestion++;
                questionLabel.Text = GroupQuestions[currentQuestion].question;
                QuestList.ItemsSource = GroupQuestions[currentQuestion].Answers;
            }
            else
            {
                if (GroupQuestions[currentQuestion].Answers.IndexOf(QuestList.SelectedItem + "") == GroupQuestions[currentQuestion].correctAnswer)
                    currentUser.coincidence += currentUser.weigth;

                DisplayAlert("", currentUser.coincidence + "", "ok");
            }
            if (currentQuestion == GroupQuestions.Count - 1)
            {
                next.Text = "Завершити";
            }
        }
    }
}