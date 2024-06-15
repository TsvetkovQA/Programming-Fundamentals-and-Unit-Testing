using System;

class Program
{
    static void Main()
    {
       
        int baseNumber = int.Parse(Console.ReadLine());

       
        int power = int.Parse(Console.ReadLine());

        int result = CalculatePower(baseNumber, power);

        Console.WriteLine($"{result}");
    }

    static int CalculatePower(int baseNumber, int power)
    {
       
        if (power == 0)
        {
            return 1;
        }

        int result = 1;
        for (int i = 1; i <= Math.Abs(power); i++)
        {
            result *= baseNumber;
        }

        
        if (power < 0)
        {
            result = 1 / result;
        }

        return result;
    }
}