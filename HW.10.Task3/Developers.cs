using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task3
{
    class Developers : TypeDevelopers
    {
        Guid _identifier;
        private protected string _companyName;
        private protected string _nameOfDevelover;
        private protected int _experienceOfDeveloper;
        private protected List<string> responsibilities = new List<string>();
        List<string> technologies = new List<string>();
        List<string> developersList = new List<string>();
        string _gitHub;
        public Developers() {}
        public Developers(string companyName, string name, int experience)
        {
            _companyName = companyName;
            _nameOfDevelover = name;
            _experienceOfDeveloper = experience;
            _gitHub = _nameOfDevelover.Trim();
        }
        public void Responsebilities()
        {
            switch (DeveloperType)
            {
                case "Junior":
                    responsibilities.Add("Знание принципов ООП");
                    responsibilities.Add("Знание основ SQL");
                    responsibilities.Add("Участвовать в сессиях оценки и планирования");
                    responsibilities.Add("Выполнять модульное и интеграционное тестирование");
                    responsibilities.Add("Участвовать в экспертных обзорах кода и дизайна");
                    break;
                case "Middle":
                    responsibilities.Add("Создание модулей API. Поддержка существующих модулей API");
                    responsibilities.Add("Поддержание существующих и создание модулей/сервисов обработки");
                    responsibilities.Add("Создание и поддержка хранимых процедур SQL для обработки данных, вычислений и отчетов");
                    responsibilities.Add("Проверка кода работы, проделанной командой");
                    responsibilities.Add("Создание и поддержка функций, триггеров");
                    break;
                case "Senior":
                    responsibilities.Add("Дизайн и разработка программного приложения");
                    responsibilities.Add("Предоставлять точные оценки по рабочим элементам");
                    responsibilities.Add("Упростить процесс разработки, чтобы обеспечить высококачественные программные решения, обеспечивающие высокое качество проектирования");
                    responsibilities.Add("Оценивать архитектуру решения с точки зрения уязвимостей и возможных улучшений");
                    responsibilities.Add("Участвовать в экспертных обзорах кода и дизайна");
                    break;
                case "Team Leader":
                    responsibilities.Add("контроль всех видов деятельности в команде");
                    responsibilities.Add("отвечает за определение целей");
                    responsibilities.Add("отвечает за распространение информации среди разработчиков");
                    responsibilities.Add("отвечает за организацию документов");
                    break;
                case "Architect":
                    responsibilities.Add("Развертывание поставленного разработчиками релиза в производстве");
                    responsibilities.Add("Интеграция и углубление процессов разработки в поставку");
                    responsibilities.Add("Стандартизация окружения разработки");
                    responsibilities.Add("Обнаружение и исправление проблем");
                    responsibilities.Add("Автоматизация процессов");
                    break;
            }
        }
        public void GetResponsebilities()
        {
            Console.WriteLine($"Responsibilities of {DeveloperType}");
            foreach (var item in responsibilities)
            {
                Console.WriteLine(item);
            }
        }
        public virtual string ShowDevelover(string developerType)
        {
            TypeDevelopers typeDevelopers = new TypeDevelopers();
            typeDevelopers.GetSalary(developerType);
            return $"\nCompany: {_companyName}, FullName: {_nameOfDevelover}, Experience: {_experienceOfDeveloper} , Title: {typeDevelopers},\nSalary: {typeDevelopers.GetSalary(_developerType)}$, GitHub: htps://github.com/{_gitHub}";
        }
        public void CreateList(string developer) 
        {
            developersList.Add(developer);
        }
    }
}
