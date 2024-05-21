using System;

public class PetFoodExpenses
{
    public static void Main(string[] args)
    {
        int dogFoodPackages = Convert.ToInt32(Console.ReadLine());
        int catFoodPackages = Convert.ToInt32(Console.ReadLine());
        const double dogFoodCostPerPackage = 2.50;
        const double catFoodCostPerPackage = 4.00;
        double totalExpenses = dogFoodPackages * dogFoodCostPerPackage + catFoodPackages * catFoodCostPerPackage;
        Console.WriteLine($"{totalExpenses:F2} lv.");
    }
}