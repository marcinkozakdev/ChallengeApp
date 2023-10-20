namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenIntsEqual_ShouldCorrectResult()
        {
            // arrange
            int number1 = 5;
            int number2 = 5;

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenFloatsEqual_ShouldCorrectResult()
        {
            // arrange
            float number1 = 3.5f;
            float number2 = 3.5f;

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenStringEqual_ShouldCorrectResult()
        {
            // arrange
            string name1 = "Adam";
            string name2 = "Adam";

            // assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void WhenEmployesNotEqual_ShouldCorrectResult()
        {
            // arrange
            Employee employee1 = GetEmployee("Adam", "Kamizelich", 'M', 35);
            Employee employee2 = GetEmployee("Adam", "Kamizelich", 'M', 40);

            // assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname, char sex, int age)
        {
            return new Employee(name, surname, sex, age);
        }
    }
}