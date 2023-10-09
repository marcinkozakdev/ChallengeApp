namespace ChallangeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Name","Surname");
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
        public void TestOfMinValue()
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
        public void TestOfMaxValue()
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
        public void TestOfArrangeValue()
        {
            // arrange
            var employee = new Employee("Marcin", "Marciniak");
            employee.AddGrade(5);
            employee.AddGrade(3);
            employee.AddGrade(7);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(5, statistics.Average);
        }
    }
}