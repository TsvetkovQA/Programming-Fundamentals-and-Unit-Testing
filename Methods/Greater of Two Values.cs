using System;

class Program
{
    static void Main()
    {
       
        string type = Console.ReadLine();

       
        string value1 = Console.ReadLine();

       
        string value2 = Console.ReadLine();

        switch (type)
        {
            case "int":
                int intValue1 = int.Parse(value1);
                int intValue2 = int.Parse(value2);
                int maxInt = Max(intValue1, intValue2);
                Console.WriteLine($"{maxInt}");
                break;
            case "char":
                char charValue1 = char.Parse(value1);
                char charValue2 = char.Parse(value2);
                char maxChar = Max(charValue1, charValue2);
                Console.WriteLine($"{maxChar}");
                break;
            case "string":
                string maxString = Max(value1, value2);
                Console.WriteLine($"{maxString}");
                break;
            
        }
    }

    static int Max(int a, int b)
    {
        return Math.Max(a, b);
    }

    static char Max(char a, char b)
    {
        return a > b ? a : b;
    }

    static string Max(string a, string b)
    {
        return string.Compare(a, b) > 0 ? a : b;
    }
}