using System;

class SchoolSupplies
{
    static void Main()
    {
        int penPackages = int.Parse(Console.ReadLine());
        int markerPackages = int.Parse(Console.ReadLine());
        int cleanerLiters = int.Parse(Console.ReadLine());
        int discountPercentage = int.Parse(Console.ReadLine());
        double penPrice = 5.80;
        double markerPrice = 7.20;
        double cleanerPrice = 1.20;
        double totalCost = (penPackages * penPrice) + (markerPackages * markerPrice) + (cleanerLiters * cleanerPrice);
        double discount = totalCost * (discountPercentage / 100.0);
        double finalCost = totalCost - discount;
        Console.WriteLine($"{finalCost:F2}");
    }
}