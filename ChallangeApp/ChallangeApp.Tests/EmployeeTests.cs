namespace ChallangeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Name", "Surname");
            employee.AddGrade(5);
            employee.AddGrade(6);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(11, result);
        }

        [Test]
        public void WhenEmployeeCollectDifferentScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Name", "Surname");
            employee.AddGrade(5);
            employee.AddGrade(-2);
            employee.AddGrade(0);
            employee.AddGrade(10);
            employee.AddGrade(-6);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(7, result);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            // arrange
            var employee = new Employee("Marcin", "Marciniak");
            employee.AddGrade(5);
            employee.AddGrade(3);
            employee.AddGrade(7);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(3, statistics.Min);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            // arrange
            var employee = new Employee("Marcin", "Marciniak");
            employee.AddGrade(5);
            employee.AddGrade(3);
            employee.AddGrade(7);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(7, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            // arrange
            var employee = new Employee("Marcin", "Marciniak");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void WhenTheGradesArePosted_ReturnTheCorrectAverageLetter()
        {
            // arrange
            var employee = new Employee("Marcin", "Marciniak");
            employee.AddGrade(20);
            employee.AddGrade(15);
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
            var employee = new Employee("Marcin", "Marciniak");
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