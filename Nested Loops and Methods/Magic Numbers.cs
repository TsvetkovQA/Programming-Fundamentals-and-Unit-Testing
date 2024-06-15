using System;
using System.Text;

class Program
{
    static void Main()
    {
        
        int N = int.Parse(Console.ReadLine());

        
        StringBuilder output = new StringBuilder();

        
        for (int num = 100; num <= 999; num++)
        {
            int a = num / 100;  
            int b = (num / 10) % 10;
            int c = num % 10;      

           
            int product = a * b * c;

            
            if (product == N)
            {
               
                output.Append(num).Append(" ");
            }
        }

        
        Console.WriteLine(output.ToString().Trim());
    }
}