using System;

class Program
{
    static void Main()
    {
       
       
        int n = int.Parse(Console.ReadLine());

        
        int currentNumber = 1;

       
        while (currentNumber <= n)
        {
           
            Console.WriteLine(currentNumber);

            
            currentNumber = 2 * currentNumber + 1;
        }
    }
}