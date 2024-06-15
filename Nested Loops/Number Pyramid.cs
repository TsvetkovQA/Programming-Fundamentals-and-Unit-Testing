using System;

class Program
{
    static void Main()
    {
       
        int n = int.Parse(Console.ReadLine());

        int currentNumber = 1;

        
        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                if (currentNumber > n)
                {
                    break;
                }
                Console.Write(currentNumber + " ");
                currentNumber++;
            }
            if (currentNumber > n)
            {
                break;
            }
            Console.WriteLine();
        }
    }
}