namespace DataTypesAndVariables;

class Program
{
    static void Main(string[] args)
    {
        int days = Convert.ToInt32(Console.ReadLine());
        int minutesPerDay = 24 * 60;
        int totalMinutes = days * minutesPerDay;
        Console.WriteLine($"Minutes = {totalMinutes}");
    }
}