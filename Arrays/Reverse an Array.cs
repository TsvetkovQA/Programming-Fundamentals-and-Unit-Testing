using System;

class Program
{
    static void Main()
    {
       
        int N = int.Parse(Console.ReadLine());

        int[] numbers = new int[N];

        
        for (int i = 0; i < N; i++)
        {
          
            numbers[i] = int.Parse(Console.ReadLine());
        }

       
        Array.Reverse(numbers);

        
       
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}