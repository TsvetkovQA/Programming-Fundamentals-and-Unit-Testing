using System;

class CurrencyConverter
{
    static void Main()
    {
        double dollars = double.Parse(Console.ReadLine());
        double exchangeRate = 0.88;
        double euros = dollars * exchangeRate;
        Console.WriteLine($"{euros:F2}");
    }
}
