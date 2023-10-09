using System.Net.NetworkInformation;

namespace ChallangeApp
{
    public class Employee
    {
        public List<int> grades = new();

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Grade { get; private set; }
        public int Result
        {
            get
            {
                return this.grades.Sum();
            }
        }

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void AddGrade(int score)
        {
            this.grades.Add(score);
        }

        public void Print()
        {
            Console.WriteLine("Pracownik z najwyższą liczbą ocen: ");
            Console.WriteLine("Imię i Nazwisko: " + Name + " " + Surname);
            Console.WriteLine("Wiek: " + Age);
            Console.WriteLine("Wynik: " + Result);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;

            }

            statistics.Average /= this.grades.Count();

            return statistics;
        }
    }
}
