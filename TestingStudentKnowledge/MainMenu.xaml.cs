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
            startTestButton.Clicked += CreateQuestions;
        }

        public List<Question> Questions = new List<Question>();

        public void CreateQuestions(object sender, EventArgs e)
        {
            Questions.Add(new Question() { Facult = "Програмування", question = "Що приймає int?", correctAnswer = 2, Answers = new List<string> { "Літери", "Слова", "Числа", "Дробні числа" } });
            Questions.Add(new Question() { Facult = "Програмування", question = "Що з переліку конвертує String в int?", correctAnswer = 3, Answers = new List<string> { "Int.Convert", "IntConvert()", "String.Convert()", "Convert.ToInt32" } });
            Questions.Add(new Question() { Facult = "Програмування", question = "Як правильно об'явити текстовий тип даних?", correctAnswer = 1, Answers = new List<string> { "String", "string", "myVarString" , "var" } });
            Questions.Add(new Question() { Facult = "Програмування", question = "Скільки батьківських класів може мати похідний клас?", correctAnswer = 1, Answers = new List<string> { "Не більше одного", "Завжди один", "Не більше двух" , "Будь-яку кількість" } });
            Questions.Add(new Question() { Facult = "Програмування", question = "Що таке масив?", correctAnswer = 2, Answers = new List<string> { "Широкий простір, однорідний за географічними ознаками: лісовий масив. житловий масив.", "Основна, найбільш висока частина гірської місцевості.", "Масив – це набір суміжних областей пам'яті, які зберігають дані певного типу.", "Виріб, що повністю складається з дорогого матеріалу (не вкритий ним): масив вишні." } });

            Questions.Add(new Question() { Facult = "Менеджемент", question = "Хто є родоначальником класичної школи менеджменту:", correctAnswer = 2, Answers = new List<string> { "Ч. Бебідж", "М. Вебер", "Ф. Тейлор", "С. Тревіс" } });
            Questions.Add(new Question() { Facult = "Менеджемент", question = "Перший підручник з управління був написаний англійським підприємцем М. Веберов у:", correctAnswer = 3, Answers = new List<string> { "1901", "1850", "1790", "1832" } });
            Questions.Add(new Question() { Facult = "Менеджемент", question = "Які бувають види поділу праці менеджерів?", correctAnswer = 1, Answers = new List<string> { "функціональне", "горизонтальне", "пряме", "не функціональне" } });
            Questions.Add(new Question() { Facult = "Менеджемент", question = "Виберіть правильні функції управління:", correctAnswer = 2, Answers = new List<string> { "планування", "розподіл", "стимулювання", "усі відповіді вірні" } });
            Questions.Add(new Question() { Facult = "Менеджемент", question = "Скільки є ієрархічних рівнів менеджменту?", correctAnswer = 1, Answers = new List<string> { "5", "3", "9", "7" } });

            Questions.Add(new Question() { Facult = "Право", question = "Обставини, які дають можливість позивачу щось вимагати у судовому засіданні, називають:", correctAnswer = 1, Answers = new List<string> { "предмет позову", "основа позову", "заперечення на позов", "спростування позову" } });
            Questions.Add(new Question() { Facult = "Право", question = "З якого моменту виникає дієздатність та правоздатність юридичної особи:", correctAnswer = 2, Answers = new List<string> { "з обговорення статуту організації", "з підписання статуту організації", "з реєстрації організації в уповноважених державних органах", "із затвердження статуту організації" } });
            Questions.Add(new Question() { Facult = "Право", question = "Які повноваження президента у сфері регулювання правового статусу громадян Ви знаєте:", correctAnswer = 0, Answers = new List<string> { "дає дозвіл на вихід із громадянства", "приймає рішення про амністію", "призначає покарання", "здійснює виконання судових рішень" } });
            Questions.Add(new Question() { Facult = "Право", question = "Що з наведеного нижче не є обов'язковою ознакою державного органу:", correctAnswer = 0, Answers = new List<string> { "право законодавчої ініціативи", "організаційна самостійність", "наявність необхідних матеріальних засобів", "владні повноваження" } });
            Questions.Add(new Question() { Facult = "Право", question = "Яка держава з наведених нижче є унітарною:", correctAnswer = 1, Answers = new List<string> { "Росія", "Франція", "Німеччина", "Бельгія" } });

            Questions.Add(new Question() { Facult = "Економіка", question = "Статистика як наука вивчає:", correctAnswer = 1, Answers = new List<string> { "поодинокі явища", "масові явища", "періодичні події", "масові події" } });
            Questions.Add(new Question() { Facult = "Економіка", question = "Термін статистика походить від слова:", correctAnswer = 3, Answers = new List<string> { "статика", "стазис", "статний", "статус" } });
            Questions.Add(new Question() { Facult = "Економіка", question = "Світова економіка – це:", correctAnswer = 2, Answers = new List<string> { "сфера стійких товарно-грошових відносин між країнами, що ґрунтується на міжнародному поділі праці", "система кредитних відносин між країнами", "сукупність національних економік країн світу, пов'язаних між собою обміном товарів, послуг та рухом факторів виробництва", "об'єднання країн у міжнародні економічні організації" } });
            Questions.Add(new Question() { Facult = "Економіка", question = "Рівень економічного розвитку характеризує показник:", correctAnswer = 0, Answers = new List<string> { "ВВП на душу населення на рік", "частка обробної промисловості обсягом промислової продукції", "загальний обсяг ВВП, вироблений протягом року", "торговельний баланс країни" } });
            Questions.Add(new Question() { Facult = "Економіка", question = "Сьогодні понад 70% світового експорту забезпечують країни:", correctAnswer = 2, Answers = new List<string> { "що розвиваються", "країни перехідної економіки", "промислово розвинені", "країни, що розвиваються, і країни перехідної економіки в сукупності" } });

            Questions.Add(new Question() { Facult = "Психологія", question = "Властивості людини, зумовлені біологічними факторами:", correctAnswer = 0, Answers = new List<string> { "задатки", "моральність", "лідерство", "всі відповіді вірні" } });
            Questions.Add(new Question() { Facult = "Психологія", question = "Особистісні властивості, зумовлені соціально, це", correctAnswer = 3, Answers = new List<string> { "рефлекси", "музичний слух", "інстинкти", "ціннісні відносини" } });
            Questions.Add(new Question() { Facult = "Психологія", question = "Здібності визначаються як:", correctAnswer = 1, Answers = new List<string> { "всі відповіді неправильні", "особливості, які не зводяться до знань, умінь, навичок", "всі відповіді вірні", "функціональні органи людини" } });
            Questions.Add(new Question() { Facult = "Психологія", question = "Поняття - це найважливіший елемент:", correctAnswer = 0, Answers = new List<string> { "мислення", "пам'яті", "сприйняття", "мови" } });
            Questions.Add(new Question() { Facult = "Психологія", question = "Уява виражається в:", correctAnswer = 0, Answers = new List<string> { "відображення реальної дійсності в нових", "усі відповіді вірні", "класифікації уявлень", "організації системи понять" } });
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
            Application.Current.Properties["questions"] = Questions;
            StartTestPage startTestPage = new StartTestPage();
            await Navigation.PushAsync(startTestPage);
        }
    }
}
