using System;

public class BoilingWaterCheck
{
    public static void Main(string[] args)
    {
        int temperature = Convert.ToInt32(Console.ReadLine());

        if (temperature > 100)
        {
            Console.WriteLine("The water is boiling");
        }
        else
        {
            Console.WriteLine("The water is not hot enough");
        }
    }
}