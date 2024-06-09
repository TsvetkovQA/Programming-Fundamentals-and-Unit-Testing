using System;

public class BonusApplier
{
    public static void Main(string[] args)
    {
        
        int stopNumber = Convert.ToInt32(Console.ReadLine());

        int previousNumber = 0;
        bool foundStopNumber = false;

        while (!foundStopNumber)
        {
            Console.WriteLine();
            int currentNumber = Convert.ToInt32(Console.ReadLine());

            if (currentNumber == stopNumber)
            {
                foundStopNumber = true;
                
                
                if (previousNumber != 0)
                {
                    double bonus = previousNumber * 0.2;
                    double newPreviousNumber = previousNumber + bonus;
                    Console.WriteLine($"{newPreviousNumber}");
                }
                
            }
            else
            {
                previousNumber = currentNumber;
            }
        }
    }
}