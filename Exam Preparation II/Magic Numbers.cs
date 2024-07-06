using System;

namespace MagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int N = int.Parse(Console.ReadLine());

            
            bool hasMagicNumbers = false;

           
            for (int i = 1; i <= N; i++)
            {
                if (IsMagicNumber(i))
                {
                    Console.Write(i + " ");
                    hasMagicNumbers = true;
                }
            }

           
            if (!hasMagicNumbers)
            {
                Console.WriteLine("no");
            }
        }

       
        static bool IsMagicNumber(int number)
        {
            int sumOfDigits = 0;
            bool allDigitsArePrime = true;
            int temp = number;

            while (temp > 0)
            {
                int digit = temp % 10;
                if (!IsPrime(digit))
                {
                    allDigitsArePrime = false;
                    break;
                }
                sumOfDigits += digit;
                temp /= 10;
            }

            return allDigitsArePrime && (sumOfDigits % 2 == 0);
        }

       
        static bool IsPrime(int digit)
        {
            return digit == 2 || digit == 3 || digit == 5 || digit == 7;
        }
    }
}