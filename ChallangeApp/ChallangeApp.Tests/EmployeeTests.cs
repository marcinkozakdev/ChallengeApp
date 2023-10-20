namespace ChallangeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new Employee("Marcin", "Marciniak", 'M', 20);
            employee.AddGrade(5);
            employee.AddGrade("3");
            employee.AddGrade(7);
            employee.AddGrade(5.2f);
            employee.AddGrade(5.2d);


            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(3, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new Employee("Marcin", "Marciniak", 'M', 20);
            employee.AddGrade(5);
            employee.AddGrade("3");
            employee.AddGrade(7);
            employee.AddGrade(5.2f);
            employee.AddGrade(5.2d);


            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(7, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            // arrange
            var employee = new Employee("Marcin", "Marciniak", 'M', 20);
            employee.AddGrade(2);
            employee.AddGrade("2");
            employee.AddGrade(6);
            employee.AddGrade(5.2f);
            employee.AddGrade(2.3d);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(3.5, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void WhenTheGradesArePosted_ReturnTheCorrectAverageLetter()
        {
            // arrange
            var employee = new Employee("Marcin", "Marciniak", 'M', 20);
            employee.AddGrade(20);
            employee.AddGrade("15");
            employee.AddGrade(10);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual('E', statistics.AverageLetter);
        }

        [Test]
        public void WhenYouIputLetters_ReturnTheCorrectAverageLetter()
        {
            // arrange
            var employee = new Employee("Marcin", "Marciniak", 'M', 20);
            employee.AddGrade('a');
            employee.AddGrade('B');
            employee.AddGrade('c');
            employee.AddGrade('D');

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual('B', statistics.AverageLetter);
        }
    }
}