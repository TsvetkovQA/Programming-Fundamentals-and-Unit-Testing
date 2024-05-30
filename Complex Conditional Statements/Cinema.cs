using System;

class Cinema
{
    static void Main()
    {
        string movieType = Console.ReadLine();
        int rowCount = int.Parse(Console.ReadLine());
        int seatCount = int.Parse(Console.ReadLine());
        
        double pricePerTicket = 0.0;
        if (movieType == "Premiere")
        {
            pricePerTicket = 12.00;
        }
        else if (movieType == "Normal")
        {
            pricePerTicket = 7.50;
        }
        else if (movieType == "Discount")
        {
            pricePerTicket = 5.00;
        }

       
        double totalPrice = pricePerTicket * rowCount * seatCount;

       
        Console.WriteLine("{0:F2}", totalPrice);
    }
}