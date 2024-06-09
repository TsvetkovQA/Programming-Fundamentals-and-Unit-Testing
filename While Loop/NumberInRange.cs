using System;

class NumberInRange
{
    static void Main()
    {
        int number;

        while (true)
        {
           
            number = int.Parse(Console.ReadLine());

           
            if (number >= 1 && number <= 100)
            {
                
                Console.WriteLine($"{number}");
                break;
            }
        }
    }
}