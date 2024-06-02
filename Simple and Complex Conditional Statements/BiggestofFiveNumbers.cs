using System;

class BiggestofFiveNumbers
{
    static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());
        int number5 = int.Parse(Console.ReadLine());

       
        int biggest = number1;

        if (number2 > biggest)
        {
            biggest = number2;
        }
        if (number3 > biggest)
        {
            biggest = number3;
        }
        if (number4 > biggest)
        {
            biggest = number4;
        }
        if (number5 > biggest)
        {
            biggest = number5;
        }

        
        Console.WriteLine(biggest);
    }
}