using System;
using System.Linq;

class Program
{
    static void Main()
    {
       
        int[] stockPrices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int startIndex = int.Parse(Console.ReadLine());
        int endIndex = int.Parse(Console.ReadLine());

        
        if (startIndex < 0 || endIndex >= stockPrices.Length || startIndex > endIndex)
        {
           
            return;
        }

        
        double sum = 0;
        int count = 0;
        for (int i = startIndex; i <= endIndex; i++)
        {
            sum += stockPrices[i];
            count++;
        }

        double average = sum / count;

       
        Console.WriteLine($"{average:F2}");
    }
}