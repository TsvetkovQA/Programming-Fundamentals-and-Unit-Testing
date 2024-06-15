using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        char startLetter = char.Parse(Console.ReadLine());
        char endLetter = char.Parse(Console.ReadLine());
        char excludedLetter = char.Parse(Console.ReadLine());

        List<string> combinations = new List<string>();
        
       
        for (char first = startLetter; first <= endLetter; first++)
        {
            for (char second = startLetter; second <= endLetter; second++)
            {
                for (char third = startLetter; third <= endLetter; third++)
                {
                    if (first != excludedLetter && second != excludedLetter && third != excludedLetter)
                    {
                        combinations.Add($"{first}{second}{third}");
                    }
                }
            }
        }

        
        foreach (string combination in combinations)
        {
            Console.Write($"{combination} ");
        }
        Console.WriteLine();
        
        
        Console.WriteLine($"{combinations.Count}");
    }
}