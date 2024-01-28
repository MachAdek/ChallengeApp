namespace ChallengeApp.Tests1
{
   public class TypeTests
    {
        [Test]
        public void Valuable()
        {
            // arrange 
            int number1 = 2;
            int number2 = 2;

            //act


            //assert
            Assert.AreEqual(number1, number2);  
        }


        [Test]
        public void Reference()
        {
            // arrange 
            var employee1 = GetEmployee("Adam", "asd", 26);
            var employee2 = GetEmployee("Adam", "qwe", 35);

            //act


            //assert
            Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string name, string password, int age)
        {
            return new Employee(name, password, age);
        }
    }
}
