namespace ChallangeApp
{
    public class Employee
    {
        public List<int> score = new();

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Score { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void AddScore(int score)
        {
            this.score.Add(score);
        }

        public void Print()
        {
            Console.WriteLine("Pracownik z najwyższą liczbą ocen: ");
            Console.WriteLine("Imię i Nazwisko: " + Name + " " + Surname);
            Console.WriteLine("Wiek: " + Age);
            Console.WriteLine("Wynik: " + Result);
        }
    }
}
