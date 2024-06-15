using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> results = new List<string>();

        while (true)
        {
            
            string destination = Console.ReadLine();

            
            if (destination == "End")
            {
                break;
            }

           
            double neededBudget = double.Parse(Console.ReadLine());

            double collectedMoney = 0;

           
            while (collectedMoney < neededBudget)
            {
                
                double money = double.Parse(Console.ReadLine());
                collectedMoney += money;

               
                results.Add($"Collected: {collectedMoney:F2}");
            }

           
            results.Add($"Going to {destination}!");
        }

        
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}