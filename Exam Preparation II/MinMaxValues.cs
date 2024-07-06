using System;
using System.Linq;

namespace MaxMinNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

           
            int N = int.Parse(Console.ReadLine());

           
            if (N > numbers.Length)
            {
                Console.WriteLine("N is larger than the length of the array.");
                return;
            }

            
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 0; i < N; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            
            Console.WriteLine(maxNumber);
            Console.WriteLine(minNumber);
        }
    }
}