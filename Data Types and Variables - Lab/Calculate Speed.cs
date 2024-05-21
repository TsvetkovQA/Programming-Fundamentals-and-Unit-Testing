using System;

public class SpeedCalculator
{
    public static void Main(string[] args)
    {
        double distance = Convert.ToDouble(Console.ReadLine());
        double time = Convert.ToDouble(Console.ReadLine());
        double speed = distance / time;
        Console.WriteLine($"{speed:F2}");
    }
}