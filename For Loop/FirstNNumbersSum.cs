using System;

class FirstNumbersSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        string expression = "";

       
        for (int i = 1; i <= n; i++)
        {
            sum += i;
            if (i == 1)
            {
                expression = i.ToString();
            }
            else
            {
                expression += "+" + i;
            }
        }

       
        expression += "=" + sum;
        Console.WriteLine(expression);
    }
}