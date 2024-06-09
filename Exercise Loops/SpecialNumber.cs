using System;

class SpecialNumber
{
    static void Main()
    {
       
        int num = int.Parse(Console.ReadLine());

       
        if (IsSpecial(num))
        {
            Console.WriteLine($"{num} is special");
        }
        else
        {
            Console.WriteLine($"{num} is not special");
        }
    }

    
    static bool IsSpecial(int num)
    {
        int temp = num;

       
        while (temp != 0)
        {
            int digit = temp % 10;
            if (digit == 0 || num % digit != 0)
            {
                return false;
            }
            temp /= 10;
        }

        return true;
    }
}