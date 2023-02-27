namespace ChallengeApp.Tests
{
    public class TypeTests
    {


        [Test]
        public void WhenTwoLoginIsSame()
        {
            var User1 = GetUser("Mateusz");
            var User2 = GetUser("Mateusz");
            Assert.AreEqual(User1.Login, User2.Login);

        }
        [Test]
        public void WhenNumberIsSame()
        {
            int number1  = 2;
            int number2  = 2;
            Assert.AreEqual(number1, number2);


        }
        [Test]
        public void TwoObjectsNotEqual()
        {
            string Employee1 = "Mateusz"; 
            string Employee2 = "Adam"; 
            Assert.AreNotEqual(Employee1, Employee2);


        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}

