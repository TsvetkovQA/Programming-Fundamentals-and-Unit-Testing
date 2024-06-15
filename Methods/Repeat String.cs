using System;

class Program
{
    static void Main()
    {
       
        string text = Console.ReadLine();

        
        int repeatCount = int.Parse(Console.ReadLine());

        
        string repeatedText = RepeatTextWithoutSpace(text, repeatCount);
        Console.WriteLine($"{repeatedText}");
    }

   
    static string RepeatTextWithoutSpace(string text, int repeatCount)
    {
        
        string textWithoutSpace = text.Replace(" ", "");

        
        string repeatedText = "";
        for (int i = 0; i < repeatCount; i++)
        {
            repeatedText += textWithoutSpace;
        }

        return repeatedText;
    }
}