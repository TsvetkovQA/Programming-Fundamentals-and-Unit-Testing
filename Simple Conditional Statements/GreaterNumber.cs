using System;

public class FindGreaterNumber
{
    public static void Main(string[] args)
    {
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int greaterNumber = number1;

        if (number2 > number1)
        {
            greaterNumber = number2;
        }

        Console.WriteLine($"Greater number: {greaterNumber}");
    }
}