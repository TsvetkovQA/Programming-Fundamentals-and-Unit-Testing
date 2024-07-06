using System;

namespace FactorialSum
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string input = Console.ReadLine();

           
            int sum = 0;

           
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    int digit = c - '0';
                    
                   
                    if (digit % 2 == 0)
                    {
                        sum += Factorial(digit);
                    }
                }
            }

           
            Console.WriteLine($"{sum}");
        }

        
        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
