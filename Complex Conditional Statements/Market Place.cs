using System;

class  PriceCalculator
{
    static void Main()
    {
        string produkt = Console.ReadLine();
        string DayOfWeek = Console.ReadLine();
        
        
       if (produkt == "Banana")
           if (DayOfWeek == "Weekday")
               Console.WriteLine("2.50");
           else 
               Console.WriteLine("2.70");
       else if (produkt == "Apple")
           if (DayOfWeek == "Weekday")
               Console.WriteLine("1.30");
           else 
               Console.WriteLine("1.60");
       else if (produkt == "Kiwi")
           if (DayOfWeek == "Weekday")
               Console.WriteLine("2.20");
           else 
               Console.WriteLine("3.00");

        
    }
}