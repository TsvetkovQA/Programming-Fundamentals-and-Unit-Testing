using System;

public class TakeawayCostCalculator
{
    public static void Main(string[] args)
    {
        int chickenMenus = int.Parse(Console.ReadLine());
        int fishMenus = int.Parse(Console.ReadLine());
        int vegetarianMenus = int.Parse(Console.ReadLine());
        double chickenCost = chickenMenus * 10.35;
        double fishCost = fishMenus * 12.40;
        double vegetarianCost = vegetarianMenus * 8.15;
        double totalFoodCost = chickenCost + fishCost + vegetarianCost;
        double dessertCost = totalFoodCost * 0.20;
        double totalOrderCost = totalFoodCost + dessertCost;
        double finalCost = totalOrderCost + 2.50;
        Console.WriteLine($"{finalCost}");
    }
}