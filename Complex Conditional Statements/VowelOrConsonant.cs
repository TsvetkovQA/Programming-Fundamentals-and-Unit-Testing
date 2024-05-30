using System;

class VowelOrConsonant
{
    static void Main()
    {
        char character = char.Parse(Console.ReadLine());
        
        if (character == 'A' || character == 'a' || character == 'E' || character == 'e' || character == 'I' || character == 'i' || character == 'O' || character == 'o' || character == 'U' || character == 'u')
        {
            Console.WriteLine("Vowel");
        }
        else
        {
            Console.WriteLine("Consonant");
        }
    }
}