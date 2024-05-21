using System;

public class CircleAreaPerimeter
{
    public static void Main(string[] args)
    {
        double radius = Convert.ToDouble(Console.ReadLine());
        double pi = Math.PI;
        double area = pi * radius * radius;
        double perimeter = 2 * pi * radius;
        Console.WriteLine($"Area = {area:F2}");
        Console.WriteLine($"Perimeter = {perimeter:F2}");
    }
}