using System;

class Program
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();
        
        if (product == "curry" || product == "noodles" || product == "sushi" || product == "spaghetti" || product == "bread")
        {
            Console.WriteLine("food");
        }
        else if (product == "tea" || product == "water" || product == "coffee" || product == "juice")
        {
            Console.WriteLine("drink");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}