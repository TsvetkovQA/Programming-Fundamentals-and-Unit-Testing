using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
       
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        
        numbers = numbers.Where(n => n >= 0).ToList();

       
        if (numbers.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            
            numbers.Reverse();

           
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
