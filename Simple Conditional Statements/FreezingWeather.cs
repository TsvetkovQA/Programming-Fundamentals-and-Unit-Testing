using System;

public class FreezingWaterCheck
{
    public static void Main(string[] args)
    {
        int temperature = Convert.ToInt32(Console.ReadLine());

        if (temperature <= 0)
        {
            Console.WriteLine("Freezing weather!");
        }
    }
}