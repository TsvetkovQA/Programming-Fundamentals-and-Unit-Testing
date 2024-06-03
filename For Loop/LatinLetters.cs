using System;

class LatinLetters
{
    static void Main()
    {
        char startLetter = char.Parse(Console.ReadLine());
        char endLetter = char.Parse(Console.ReadLine());

        if (startLetter > endLetter)
        {
            char temp = startLetter;
            startLetter = endLetter;
            endLetter = temp;
        }

       
        for (char letter = startLetter; letter <= endLetter; letter++)
        {
            
            Console.Write(letter + " ");
        }

       
        Console.WriteLine();
    }
}