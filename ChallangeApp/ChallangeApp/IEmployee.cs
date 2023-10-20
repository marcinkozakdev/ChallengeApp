namespace ChallangeApp
{
    public interface IEmployee
    {
        public string Name { get;}
        public string Surname { get;}
        public char Sex { get;}
        public int Age { get;}
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(decimal grade);
        void AddGrade(char grade);
        Statistics GetStatistics();
    }
}
