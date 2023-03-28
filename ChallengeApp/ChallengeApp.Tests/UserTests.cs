namespace ChallengeApp.Tests
{
    public class Tests
    {
    
        [Test]
        public void WhenUserCollectPointsResult()
        {
            var user = new User("Mateusz", "sdadasdasd");
            user.Addscore(3);
            user.Addscore(4);
            user.Addscore(-2);

            var result = user.Result;

            Assert.AreEqual(5, result);

        }
    }
}