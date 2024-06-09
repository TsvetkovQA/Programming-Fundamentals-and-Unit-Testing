using System;

class OddNumber
{
    static void Main()
    {
        int number;

        while (true)
        {
           
            number = int.Parse(Console.ReadLine());

            
            if (number % 2 != 0)
            {
                break;
            }
        }

        
        Console.WriteLine(number);
    }
}