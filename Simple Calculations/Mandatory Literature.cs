using System;

class ReadingTimeCalculator
{
    static void Main()
    {
        int totalPages = int.Parse(Console.ReadLine());
        int pagesPerHour = int.Parse(Console.ReadLine());
        int daysToFinish = int.Parse(Console.ReadLine());
        int totalHours = totalPages / pagesPerHour;
        int hoursPerDay = totalHours / daysToFinish;
        Console.WriteLine(hoursPerDay);
    }
}