namespace ChallangeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Name","Surname",30);
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
            var employee = new Employee("Name", "Surname", 30);
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
    }
}