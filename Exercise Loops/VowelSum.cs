using System;

class VowelSum
{
    static void Main()
    {
        
        int sum = 0;

        
       
        int n = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < n; i++)
        {
           
            char ch = char.ToLower(Console.ReadLine()[0]);
            
            switch (ch)
            {
                case 'a':
                    sum += 1;
                    break;
                case 'e':
                    sum += 2;
                    break;
                case 'i':
                    sum += 3;
                    break;
                case 'o':
                    sum += 4;
                    break;
                case 'u':
                    sum += 5;
                    break;
            }
        }

        
        Console.WriteLine($"{sum}");
    }
}