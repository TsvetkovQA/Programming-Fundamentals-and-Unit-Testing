using System;

class Program
{
    static void Main()
    {
       
        string text = Console.ReadLine();

        
        int vowelCount = CountVowels(text);
        Console.WriteLine($"{vowelCount}");
    }

    
    static int CountVowels(string text)
    {
        
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

       
        int count = 0;

        
        foreach (char c in text)
        {
            
            if (Array.IndexOf(vowels, c) != -1)
            {
                count++; 
            }
        }

        return count;
    }
}