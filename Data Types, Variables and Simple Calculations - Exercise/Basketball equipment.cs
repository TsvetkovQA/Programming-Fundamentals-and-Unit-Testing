using System;

public class BasketballTrainingCostCalculator
{
    public static void Main(string[] args)
    {
        int annualTrainingFee = int.Parse(Console.ReadLine());
        double sneakersPrice = annualTrainingFee * 0.60;
        double uniformPrice = sneakersPrice * 0.80;
        double basketballPrice = uniformPrice * 0.25;
        double accessoriesPrice = basketballPrice * 0.20;
        double totalCost = annualTrainingFee + sneakersPrice + uniformPrice + basketballPrice + accessoriesPrice;
        Console.WriteLine($"{totalCost}");
    }
}