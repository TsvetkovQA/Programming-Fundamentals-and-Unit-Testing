using System;

public class TicketPriceCalculator
{
    public static void Main(string[] args)
    {

        string ticketType = Console.ReadLine().ToLower();

        decimal price;
        if (ticketType == "student")
        {
            price = 1.00m;
            Console.WriteLine($"${price}");
        }
        else if (ticketType == "regular")
        {
            price = 1.60m;
            Console.WriteLine($"${price}");
        }
        else
        {
            Console.WriteLine("Invalid ticket type!");
        }
    }
}