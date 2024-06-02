using System;

class FruitOrVegetable
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();

       
        if (product == "banana" || product == "apple" || product == "kiwi" || 
            product == "cherry" || product == "lemon")
        {
            Console.WriteLine("fruit");
        }
        else if (product == "cucumber" || product == "pepper" || product == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}