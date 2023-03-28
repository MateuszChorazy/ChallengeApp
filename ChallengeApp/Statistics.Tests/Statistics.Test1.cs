using ChallengeApp;

namespace Statistics.Tests
{
  
    
        public class StatisticsTests
        {
            [Test]
            public void Statistics()
            {
                var employee = new Employee("Mateusz", "Kowal");
                employee.Addgrade(5);
                employee.Addgrade(3);
                employee.Addgrade(4);

                var statistics = employee.GetStatistics();

                Assert.AreEqual(4, statistics.Average);
            }

            [Test]
            public void StatisticsMin()
            {
                var employee = new Employee("Mateusz", "Kowal");
                employee.Addgrade(5);
                employee.Addgrade(3);
                employee.Addgrade(4);

                var statistics = employee.GetStatistics();

                Assert.AreEqual(3, statistics.Min);
            }

            [Test]
            public void StatisticsMax()
            {
                var employee = new Employee("Mateusz", "Kowal");
                employee.Addgrade(5);
                employee.Addgrade(3);
                employee.Addgrade(4);

                var statistics = employee.GetStatistics();

                Assert.AreEqual(5, statistics.Max);
            }
        }
    
}
