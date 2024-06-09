using System;
using System.Collections.Generic;

class AccountBalance
{
    static void Main()
    {
        List<double> transactions = new List<double>();

        Console.WriteLine();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            double money = double.Parse(input);
            transactions.Add(money);
        }

        Console.WriteLine();
        double balance = 0;
        foreach (double money in transactions)
        {
            if (money > 0)
            {
                Console.WriteLine($"Increase: {money:F2}");
            }
            else if (money < 0)
            {
                Console.WriteLine($"Decrease: {Math.Abs(money):F2}");
            }
            

            balance += money;
        }

        Console.WriteLine($"Balance: {balance:F2}");
    }
}