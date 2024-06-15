using System;

class Program
{
    static void Main()
    {
      
        int floors = int.Parse(Console.ReadLine());

       
        int estatesPerFloor = int.Parse(Console.ReadLine());

       
        for (int floor = floors; floor >= 1; floor--)
        {
            for (int estate = 0; estate < estatesPerFloor; estate++)
            {
                string type = GetEstateType(floor, floors);
                Console.Write($"{type}{floor}{estate} ");
            }
            Console.WriteLine();
        }
    }

    static string GetEstateType(int currentFloor, int totalFloors)
    {
        if (currentFloor == totalFloors)
        {
            return "L";
        }
        else if (currentFloor % 2 == 0)
        {
            return "O";
        }
        else
        {
            return "A";
        }
    }
}