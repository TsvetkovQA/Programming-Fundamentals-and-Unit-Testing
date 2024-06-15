using System;

class Program
{
    static void Main()
    {
        
        int size = int.Parse(Console.ReadLine());

       
        for (int i = 1; i <= size; i++)
        {
            PrintLineOfStars(i);
        }
    }

    static void PrintLineOfStars(int numberOfStars)
    {
        for (int i = 0; i < numberOfStars; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}