using System;
using System.Linq;

namespace AverageMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            
            if (numbers.Length % 2 != 0)
            {
                
                return;
            }

            
            int middleIndex1 = (numbers.Length / 2) - 1;
            int middleIndex2 = numbers.Length / 2;
            double average = (numbers[middleIndex1] + numbers[middleIndex2]) / 2.0;

            
            Console.WriteLine($"{average:F2}");
        }
    }
}