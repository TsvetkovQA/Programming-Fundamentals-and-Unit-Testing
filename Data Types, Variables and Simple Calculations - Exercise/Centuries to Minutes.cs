using System;

class CenturiesToMinutes
{
    static void Main()
    {
        int centuries = int.Parse(Console.ReadLine());
        int years = centuries * 100;
        double days = years * 365.2422;
        long totalDays = (long)Math.Floor(days);
        long hours = totalDays * 24;
        long minutes = hours * 60;
        Console.WriteLine($"{centuries} centuries = {years} years = {totalDays} days = {hours} hours = {minutes} minutes");
    }
}