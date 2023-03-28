namespace ChallengeApp.Test
{
    public class Statistics
    {
        [Test]
        public void CorrectStatisticsAverage()
        {
            var employee = new Employee("Mateusz");
            employee.Addgrade(5);
            employee.Addgrade(3);
            employee.Addgrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(4, statistics.Average);
        }

        [Test]
        public void CorrectStatisticsMin()
        {
            var employee = new Employee("Kasia", "Kowalska");
            employee.Addgrade(5);
            employee.Addgrade(3);
            employee.Addgrade(4);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(3, Statistics.Min);
        }

        [Test]
        public void CorrectStatisticsMax()
        {
            var employee = new Employee("Kasia", "Kowalska");
            employee.Addgrade(5);
            employee.Addgrade(3);
            employee.Addgrade(4);

            var Statistics = employee.GetStatistics();

            Assert.AreEqual(5, Statistics.Max);
        }
    }
}