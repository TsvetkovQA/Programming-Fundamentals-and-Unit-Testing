using System;

class Program
{
    static void Main()
    {
      
        
        int number1 = ReadIntegerInRange(1, 10);
        int number2 = ReadIntegerInRange(1, 10);
        
        
        long factorial1 = CalculateFactorial(number1);
        long factorial2 = CalculateFactorial(number2);
        
        
        long result = factorial1 / factorial2;
        
        
        Console.WriteLine($"{result}");
    }
    
    
    static int ReadIntegerInRange(int min, int max)
    {
        int number;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number) && number >= min && number <= max)
            {
                return number;
            }
            else
            {
                Console.WriteLine($"Please enter an integer between {min} and {max}:");
            }
        }
    }
    
    
    static long CalculateFactorial(int number)
    {
        long factorial = 1;
        
        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        
        return factorial;
    }
}