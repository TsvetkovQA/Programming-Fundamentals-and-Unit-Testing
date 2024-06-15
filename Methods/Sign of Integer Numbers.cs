using System;

class Program
{
    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());

        
        PrintNumberSign(N);
    }

    
    static void PrintNumberSign(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("The number {0} is positive.", number);
        }
        else if (number < 0)
        {
            Console.WriteLine("The number {0} is negative.", number);
        }
        else
        {
            Console.WriteLine("The number {0} is zero.", number);
        }
    }
}