using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        int start = int.Parse(Console.ReadLine());

       
        int end = int.Parse(Console.ReadLine());

        
        List<int> primes = new List<int>();

        
        for (int number = start; number <= end; number++)
        {
            if (IsPrime(number))
            {
                primes.Add(number);
            }
        }

        
        Console.WriteLine(string.Join(" ", primes));
    }

   
    static bool IsPrime(int number)
    {
       
        if (number <= 1)
        {
            return false;
        }

        
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }    
}