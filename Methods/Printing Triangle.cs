using System;

class Program
{
    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());

        
        PrintTrianglePattern(N);
    }

    
    static void PrintTrianglePattern(int N)
    {
        
        for (int row = 1; row <= N; row++)
        {
            
            for (int num = 1; num <= row; num++)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        
        for (int row = N - 1; row >= 1; row--)
        {
            
            for (int num = 1; num <= row; num++)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}