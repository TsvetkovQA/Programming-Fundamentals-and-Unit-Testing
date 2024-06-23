using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
       
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] commandParts = command.Split();
            string action = commandParts[0];

            if (action == "Delete")
            {
                int element = int.Parse(commandParts[1]);
                numbers.RemoveAll(e => e == element);
            }
            else if (action == "Insert")
            {
                int element = int.Parse(commandParts[1]);
                int position = int.Parse(commandParts[2]);
                numbers.Insert(position, element);
            }
        }

        
        Console.WriteLine(string.Join(" ", numbers));
    }
}
