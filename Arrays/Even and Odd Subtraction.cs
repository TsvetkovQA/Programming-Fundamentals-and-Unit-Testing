using System;

class Program
{
    static void Main()
    {
       
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int sumEven = 0;
        int sumOdd = 0;

        foreach (string number in numbers)
        {
            int num = int.Parse(number);
            if (num % 2 == 0)
            {
                sumEven += num;
            }
            else
            {
                sumOdd += num;
            }
        }

        int difference = sumEven - sumOdd;
        Console.WriteLine($"{difference}");
    }
}