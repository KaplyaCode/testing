using System.ComponentModel;

namespace TestingStudentKnowledge
{
    public class Result : INotifyPropertyChanged
    {
        private string surname;
        private string faculty;
        private double score;

        public string Surname
        {
            get { return surname; }
            set
            {
                if (surname != value)
                {
                    surname = value;
                    OnPropertyChanged("Surname");
                }
            }
        }

        public string Faculty
        {
            get { return faculty; }
            set
            {
                if (faculty != value)
                {
                    faculty = value;
                    OnPropertyChanged("Faculty");
                }
            }
        }

        public double Score
        {
            get { return score; }
            set
            {
                if (score != value)
                {
                    score = value;
                    OnPropertyChanged("Score");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
