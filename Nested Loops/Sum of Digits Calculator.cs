using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> results = new List<string>();

        while (true)
        {
           
            string input = Console.ReadLine();

            
            if (input == "End")
            {
                break;
            }

           
            int number = int.Parse(input);
            int sumOfDigits = CalculateSumOfDigits(number);

           
            results.Add($"Sum of digits = {sumOfDigits}");
        }

       
        foreach (string result in results)
        {
            Console.WriteLine(result);
        }

       
        Console.WriteLine("Goodbye");
    }

    
    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}