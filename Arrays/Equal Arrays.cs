using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        string input1 = Console.ReadLine();
        int[] array1 = input1.Split(' ').Select(int.Parse).ToArray();

       
        string input2 = Console.ReadLine();
        int[] array2 = input2.Split(' ').Select(int.Parse).ToArray();

        bool areEqual = array1.SequenceEqual(array2);

        if (areEqual)
        {
            Console.WriteLine("Arrays are identical.");
        }
        else
        {
            Console.WriteLine("Arrays are not identical.");
        }
    }
}