using System;

class SimpleTriangleChecker
{
    static void Main()
    {
        int side1 = int.Parse(Console.ReadLine());
        int side2 = int.Parse(Console.ReadLine());
        int side3 = int.Parse(Console.ReadLine());

       
        if (side1 >= side2 + side3)
        {
            Console.WriteLine("Invalid Triangle");
        }
        
        else if (side2 >= side1 + side3)
        {
            Console.WriteLine("Invalid Triangle");
        }
        
        else if (side3 >= side1 + side2)
        {
            Console.WriteLine("Invalid Triangle");
        }
        
        else
        {
            Console.WriteLine("Valid Triangle");
        }
    }
}