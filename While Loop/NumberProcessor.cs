using System;

class NumberProcessor
{
    static void Main()
    {
       
        int number = int.Parse(Console.ReadLine());

        while (true)
        {
            
            string command = Console.ReadLine();

           
            if (command == "Inc")
            {
                number++;
            }
            else if (command == "Dec")
            {
                number--;
            }
            else if (command == "End")
            {
               
                Console.WriteLine($"{number}");
                break;
            }
        }
    }
}