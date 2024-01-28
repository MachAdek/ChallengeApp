namespace ChallengeApp.Tests1
{
    public class UserTests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectSumAsResult()
        {
            // arrange 
            var employee = new Employee("Adam", "asdasdsa", 26);
            employee.AddScore(5);
            employee.AddScore(6);
            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(11, result);
        }
    }
    public class Tests1
    {
        [Test]
        public void WhenUserCollectTwoMinusScore_ShouldReturnCorrectSumAsResult()
        {
            // arrange 
            var employee = new Employee("Adam", "asdasdsa", 26);
            employee.AddScore(-1);
            employee.AddScore(-3);
            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-4, result);
        }
    }
    public class Tests2
    {
        [Test]
        public void WhenUserCollectMinusAndPlusScore_ShouldReturnCorrectSumAsResult()
        {
            // arrange 
            var employee = new Employee("Adam", "asdasdsa", 26);
            employee.AddScore(5);
            employee.AddScore(-5);
            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(0, result);
        }
    }
}