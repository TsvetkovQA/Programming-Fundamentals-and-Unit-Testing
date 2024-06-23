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

            if (action == "Add")
            {
                int number = int.Parse(commandParts[1]);
                numbers.Add(number);
            }
            else if (action == "Remove")
            {
                int number = int.Parse(commandParts[1]);
                numbers.Remove(number);
            }
            else if (action == "RemoveAt")
            {
                int index = int.Parse(commandParts[1]);
                numbers.RemoveAt(index);
            }
            else if (action == "Insert")
            {
                int number = int.Parse(commandParts[1]);
                int index = int.Parse(commandParts[2]);
                numbers.Insert(index, number);
            }
        }

       
        Console.WriteLine(string.Join(" ", numbers));
    }
}
