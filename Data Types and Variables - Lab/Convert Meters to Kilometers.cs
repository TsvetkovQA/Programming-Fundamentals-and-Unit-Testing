using System;

public class MetersToKilometers
{
    public static void Main(string[] args)
    {
        double distanceMeters = Convert.ToDouble(Console.ReadLine());
        const double conversionRate = 1000.0;
        double distanceKilometers = distanceMeters / conversionRate;
        Console.WriteLine($"{distanceKilometers:F2}");
    }
}