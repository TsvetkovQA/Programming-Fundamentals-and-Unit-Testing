using System;

namespace NumberToWords
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string input = Console.ReadLine();

           
            if (int.TryParse(input, out int number) && number > 0)
            {
                PrintDigitsInWords(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

        static void PrintDigitsInWords(int number)
        {
           
            string numberStr = number.ToString();
            for (int i = numberStr.Length - 1; i >= 0; i--)
            {
                char digit = numberStr[i];
                Console.WriteLine(DigitToWord(digit));
            }
        }

        static string DigitToWord(char digit)
        {
            return digit switch
            {
                '1' => "one",
                '2' => "two",
                '3' => "three",
                '4' => "four",
                '5' => "five",
                '6' => "six",
                '7' => "seven",
                '8' => "eight",
                '9' => "nine",
                '0' => "zero",
                _ => "unknown"
            };
        }
    }
}