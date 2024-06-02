using System;

class WorkingHours
{
    static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        string dayOfWeek = Console.ReadLine().ToLower();
        bool isOpen = false;

        if (hour >= 10 && hour <= 18)
        {
            if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" ||
                dayOfWeek == "thursday" || dayOfWeek == "friday" || dayOfWeek == "saturday")
            {
                isOpen = true;
            }
        }

       
        if (isOpen)
        {
            Console.WriteLine("open");
        }
        else
        {
            Console.WriteLine("closed");
        }
    }
}