using System;

class DepositCalculator
{
    static void Main()
    {
        double depositedAmount = double.Parse(Console.ReadLine());
        int termOfDeposit = int.Parse(Console.ReadLine());
        double annualInterestRate = double.Parse(Console.ReadLine());
        double finalAmount = depositedAmount + termOfDeposit * (depositedAmount * annualInterestRate / 100) / 12;
        Console.WriteLine($"{finalAmount:F2}");
    }
}