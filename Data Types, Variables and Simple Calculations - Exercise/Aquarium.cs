using System;

public class AquariumWaterCalculator
{
    public static void Main(string[] args)
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double occupiedPercentage = double.Parse(Console.ReadLine()) / 100;
        double aquariumVolume = length * width * height;
        double occupiedVolume = aquariumVolume * occupiedPercentage;
        double waterVolume = aquariumVolume - occupiedVolume;
        waterVolume /= 1000;

       
        Console.WriteLine($"{waterVolume:F2}");
    }
}