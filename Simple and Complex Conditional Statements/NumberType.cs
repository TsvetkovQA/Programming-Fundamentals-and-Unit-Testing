using System;

class NumberType
{
    static void Main()
    {
        
        int number = int.Parse(Console.ReadLine());

       
        if (number < 0)
        {
            Console.WriteLine("negative");
        }
        else if (number > 0)
        {
            Console.WriteLine("positive");
        }
        else
        {
            Console.WriteLine("zero");
        }
    }
}