using System;

class DivisionTo
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

       
        int countDivisibleBy2 = 0;
        int countDivisibleBy3 = 0;
        int countDivisibleBy4 = 0;

        for (int i = 0; i < n; i++)
        {
           
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                countDivisibleBy2++;
            }

            if (number % 3 == 0)
            {
                countDivisibleBy3++;
            }

            if (number % 4 == 0)
            {
                countDivisibleBy4++;
            }
        }

       
        double percentDivisibleBy2 = (double)countDivisibleBy2 / n * 100;
        double percentDivisibleBy3 = (double)countDivisibleBy3 / n * 100;
        double percentDivisibleBy4 = (double)countDivisibleBy4 / n * 100;

        
        Console.WriteLine($"{percentDivisibleBy2:F2}%");
        Console.WriteLine($"{percentDivisibleBy3:F2}%");
        Console.WriteLine($"{percentDivisibleBy4:F2}%");
    }
}