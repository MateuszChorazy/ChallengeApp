int[] grades = new int[365];
List<string> dayOfweeks = new List<string>();
dayOfweeks.Add("poniedziałek");
dayOfweeks.Add("wtorek");
dayOfweeks.Add("środa");
dayOfweeks.Add("czwartek");
dayOfweeks.Add("piątek");
dayOfweeks.Add("sobota");
dayOfweeks.Add("niedziela");


foreach(var day in dayOfweeks) 
{
    Console.WriteLine(day);
}
