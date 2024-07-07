using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        int N = int.Parse(Console.ReadLine());

        
        if (N <= 0)
        {
            Console.WriteLine(0);
            return;
        }

        List<int> caloricValues = new List<int>();
        
        
        for (int i = 0; i < N; i++)
        {
            
            int calories = int.Parse(Console.ReadLine());
            caloricValues.Add(calories);
        }

        int cumulativeCalories = 0;
        List<int> cumulativeCaloricIntake = new List<int>();

       
        foreach (int calories in caloricValues)
        {
            cumulativeCalories += calories;
            cumulativeCaloricIntake.Add(cumulativeCalories);
        }

        
        foreach (int cumulative in cumulativeCaloricIntake)
        {
            Console.WriteLine(cumulative);
        }
    }
}