using System;

class NumbersEndingIn7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 7; i <= n; i++)
        {
            
            if (i % 10 == 7)
            {
               
                Console.WriteLine(i);
            }
        }
    }
}