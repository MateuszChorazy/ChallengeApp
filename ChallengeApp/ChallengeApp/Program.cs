using ChallengeApp;

var employee = new Employee("Mateusz", "Chorąży");
employee.Addgrade(2);
employee.Addgrade(3);
employee.Addgrade(4);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

void SetSth(Statistics statistics)
{
    statistics = new Statistics();
}