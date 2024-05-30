using System;

class Program
{
    static void Main()
    {
        
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

       
        if (first > second && first > third)
        {
            Console.WriteLine(first);
        }
        else if (second > first && second > third)
        {
            Console.WriteLine(second);
        }
        else
        {
            Console.WriteLine(third);
        }
    }
}
