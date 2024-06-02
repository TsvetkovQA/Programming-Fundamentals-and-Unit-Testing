using System;

class VacationExpenses
{
    static void Main()
    {
        string season = Console.ReadLine().ToLower();
        string accommodationType = Console.ReadLine().ToLower();
        int days = int.Parse(Console.ReadLine());
        double pricePerNight = 0.0;
        double discount = 0.0;

        if (season == "spring")
        {
            if (accommodationType == "hotel")
            {
                pricePerNight = 30;
                discount = 0.20;
            }
            else if (accommodationType == "camping")
            {
                pricePerNight = 10;
                discount = 0.20;
            }
        }
        else if (season == "summer")
        {
            if (accommodationType == "hotel")
            {
                pricePerNight = 50;
            }
            else if (accommodationType == "camping")
            {
                pricePerNight = 30;
            }
        }
        else if (season == "autumn")
        {
            if (accommodationType == "hotel")
            {
                pricePerNight = 20;
                discount = 0.30;
            }
            else if (accommodationType == "camping")
            {
                pricePerNight = 15;
                discount = 0.30;
            }
        }
        else if (season == "winter")
        {
            if (accommodationType == "hotel")
            {
                pricePerNight = 40;
                discount = 0.10;
            }
            else if (accommodationType == "camping")
            {
                pricePerNight = 10;
                discount = 0.10;
            }
        }

       
        double totalExpenses = pricePerNight * days;
        totalExpenses -= totalExpenses * discount;

       
        Console.WriteLine("{0:F2}", totalExpenses);
    }
}
