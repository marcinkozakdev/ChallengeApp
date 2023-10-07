namespace ChallangeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Name","Surname",30);
            employee.AddScore(5);
            employee.AddScore(6);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(11, result);
        }

        [Test]
        public void WhenEmployeeCollectDifferentScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Name", "Surname", 30);
            employee.AddScore(5);
            employee.AddScore(-2);
            employee.AddScore(0);
            employee.AddScore(10);
            employee.AddScore(-6);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(7, result);
        }
    }
}