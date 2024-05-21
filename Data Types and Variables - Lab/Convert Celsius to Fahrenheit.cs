using System;

public class CelsiusToFahrenheit
{
    public static void Main(string[] args)
    {
        double temperatureCelsius = Convert.ToDouble(Console.ReadLine());
        const double conversionFactor = 1.8;
        const double fahrenheitOffset = 32.0;
        double temperatureFahrenheit = temperatureCelsius * conversionFactor + fahrenheitOffset;
        Console.WriteLine($"{temperatureFahrenheit:F2}");
    }
}