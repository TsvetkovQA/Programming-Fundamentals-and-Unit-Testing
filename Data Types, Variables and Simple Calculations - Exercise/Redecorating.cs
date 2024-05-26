using System;

public class RepairCostCalculator
{
    public static void Main(string[] args)
    {
      
        double nylonAmount = double.Parse(Console.ReadLine());
        double paintAmount = double.Parse(Console.ReadLine());
        double thinnerAmount = double.Parse(Console.ReadLine());
        int workHours = int.Parse(Console.ReadLine());

        
        double nylonCost = (nylonAmount + 2) * 1.50;
        double paintCost = (paintAmount * 1.10) * 14.50;
        double thinnerCost = thinnerAmount * 5.00;
        double bagCost = 0.40;
        double totalMaterialCost = nylonCost + paintCost + thinnerCost + bagCost;
        double amountForCraftsmen = totalMaterialCost * 0.30 * workHours;
        double totalCost = totalMaterialCost + amountForCraftsmen;
        
        Console.WriteLine($"{totalCost}");
    }
}