using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
       
        int N = int.Parse(Console.ReadLine());

       
        List<string> passwords = new List<string>();

        
        for (int first = 2; first <= N; first += 2)
        {
            for (int second = 1; second <= N; second += 2)
            {
                int third = first * second;
                string password = $"{first}{second}{third}";
                passwords.Add(password);
            }
        }

        
        string output = string.Join(" ", passwords);
        Console.WriteLine(output);
    }
}