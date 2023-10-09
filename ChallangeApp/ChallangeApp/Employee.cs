using System.Net.NetworkInformation;

namespace ChallangeApp
{
    public class Employee
    {
        public List<int> grades = new();

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Grade { get; private set; }
        public int Result
        {
            get
            {
                return this.grades.Sum();
            }
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddGrade(int score)
        {
            this.grades.Add(score);
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
