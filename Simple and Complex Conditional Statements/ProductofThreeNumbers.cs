using System;

class ProductofThreeNumbers
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        double number3 = double.Parse(Console.ReadLine());

       
        if (number1 == 0 || number2 == 0 || number3 == 0)
        {
            Console.WriteLine("zero");
        }
        else
        {
           
            int negativeCount = 0;

            if (number1 < 0)
                negativeCount++;
            if (number2 < 0)
                negativeCount++;
            if (number3 < 0)
                negativeCount++;

           
            if (negativeCount % 2 == 1)
            {
                Console.WriteLine("negative");
            }
            else
            {
                
                Console.WriteLine("positive");
            }
        }
    }
}