using System;

class TileCalculator
{
    static void Main()
    {
        double bathroomWidth = double.Parse(Console.ReadLine());
        double bathroomHeight = double.Parse(Console.ReadLine());
        double tileWidth = double.Parse(Console.ReadLine());
        double tileHeight = double.Parse(Console.ReadLine());
        double bathroomArea = bathroomWidth * bathroomHeight;
        double tileArea = tileWidth * tileHeight;
        double neededTiles = bathroomArea / tileArea;
        neededTiles *= 1.10;
        int totalTiles = (int)Math.Ceiling(neededTiles);
        Console.WriteLine($"{totalTiles}");
    }
}