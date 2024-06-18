using System;

class Program
{
    static void Main()
    {
       
        string input = Console.ReadLine();

       
        string[] numbers = input.Split(' ');

        int sum = 0;

        
        foreach (string num in numbers)
        {
            sum += int.Parse(num);
        }

        
        Console.WriteLine($"{sum}");
    }
}