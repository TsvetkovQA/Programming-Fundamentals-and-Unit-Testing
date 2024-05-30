using System;

public class SpeedChecker
{
    public static void Main(string[] args)
    {
        float speed = float.Parse(Console.ReadLine());

        if (speed <= 30)
        {
            Console.WriteLine("Slow");
        }
        else
        {
            Console.WriteLine("Fast");
        }
    }
}