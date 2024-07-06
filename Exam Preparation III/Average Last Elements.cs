using System;
using System.Linq;

namespace AverageOfLastNElements
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

           
            int N = int.Parse(Console.ReadLine());

           
            if (N > numbers.Length || N <= 0)
            {
                Console.WriteLine("Invalid input. N must be positive and less than or equal to the length of the array.");
                return;
            }

           
            double average = numbers.Skip(numbers.Length - N).Average();

            
            Console.WriteLine($"{average:F2}");
        }
    }
}