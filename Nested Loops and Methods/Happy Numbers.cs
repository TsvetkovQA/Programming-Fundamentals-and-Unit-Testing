using System;

class Program
{
    static void Main()
    {
       
        int N = int.Parse(Console.ReadLine());

        
        bool isFirst = true;

        
        for (int d1 = 1; d1 <= 9; d1++) 
        {
            for (int d2 = 0; d2 <= 9; d2++)
            {
                for (int d3 = 0; d3 <= 9; d3++)
                {
                    for (int d4 = 0; d4 <= 9; d4++)
                    {
                       
                        if (d1 + d2 == N && d3 + d4 == N)
                        {
                           
                            if (!isFirst)
                            {
                                Console.Write(" ");
                            }
                            Console.Write($"{d1}{d2}{d3}{d4}");
                            isFirst = false;
                        }
                    }
                }
            }
        }
        
        Console.WriteLine();
    }
}