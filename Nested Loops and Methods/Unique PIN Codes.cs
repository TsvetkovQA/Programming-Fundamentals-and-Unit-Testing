using System;

class Program
{
    static void Main()
    {
       
        int max1 = int.Parse(Console.ReadLine());
        int max2 = int.Parse(Console.ReadLine());
        int max3 = int.Parse(Console.ReadLine());

        
        int[] primes = { 2, 3, 5, 7 };

       
        for (int d1 = 2; d1 <= max1; d1 += 2) 
        {
            for (int d2Index = 0; d2Index < primes.Length; d2Index++)
            {
                int d2 = primes[d2Index];

                if (d2 <= max2)
                {
                    for (int d3 = 2; d3 <= max3; d3 += 2)
                    {
                       
                        Console.WriteLine($"{d1}{d2}{d3}");
                    }
                }
            }
        }
    }
}