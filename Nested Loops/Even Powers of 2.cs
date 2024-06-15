using System;

class Program
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

        
        for (int i = 0; i <= n; i += 2)
        {
            int result = (int)Math.Pow(2, i);
            Console.WriteLine(result);
        }
    }
}