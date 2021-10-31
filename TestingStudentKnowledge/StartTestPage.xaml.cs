using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            programmingButton.Clicked += ProgrammingGroupCreate;
            lawButton.Clicked += LawGroupCreate;
            economicButton.Clicked += EconomicGroupCreate;
            psychologyButton.Clicked += PsychologyGroupCreate;
            managerButton.Clicked += ManagerGroupCreate;
        }

        public List<Question> InputList = (List<Question>)Application.Current.Properties["questions"];
        public List<Question> ProgrammingGroup = new List<Question>();
        public List<Question> LawGroup = new List<Question>();
        public List<Question> EconomicGroup = new List<Question>();
        public List<Question> PsychologyGroup = new List<Question>();
        public List<Question> ManagerGroup = new List<Question>();

        public User currentUser = (User)Application.Current.Properties["currentUser"];
        public int coincidenceDivider = 0;


        public void ProgrammingGroupCreate(object sender, EventArgs e)
        {
            foreach (var item in InputList)
                if (item.Facult == "Програмування")
                {
                    ProgrammingGroup.Add(item);
                    coincidenceDivider++;
                }

            Application.Current.Properties["groupQuestions"] = ProgrammingGroup;
        }

        public void LawGroupCreate(object sender, EventArgs e)
        {
            foreach (var item in InputList)
                if (item.Facult == "Право")
                {
                    LawGroup.Add(item);
                    coincidenceDivider++;
                }

            Application.Current.Properties["questions"] = LawGroup;
        }

        public void EconomicGroupCreate(object sender, EventArgs e)
        {
            foreach (var item in InputList)
                if (item.Facult == "Економіка") 
                {
                    EconomicGroup.Add(item);
                    coincidenceDivider++;
                }

            Application.Current.Properties["questions"] = EconomicGroup;
        }

        public void PsychologyGroupCreate(object sender, EventArgs e)
        {
            foreach (var item in InputList)
                if (item.Facult == "Психологія")
                {
                    PsychologyGroup.Add(item);
                    coincidenceDivider++;
                }

            Application.Current.Properties["questions"] = PsychologyGroup;
        }

        public void ManagerGroupCreate(object sender, EventArgs e)
        {
            foreach (var item in InputList)
                if (item.Facult == "Менеджемент")
                {
                    ManagerGroup.Add(item);
                    coincidenceDivider++;
                }

            Application.Current.Properties["questions"] = ManagerGroup;
        }

        private async void GoToMainMenu(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void GoToTestPage(object sender, EventArgs e)
        {
            await Task.Delay(150);
            currentUser.weigth = (double)(currentUser.weigth / coincidenceDivider);
            Application.Current.Properties["currentUser"] = currentUser;
            TestPage testPage = new TestPage();
            await Navigation.PushAsync(testPage);
        }
    }
}