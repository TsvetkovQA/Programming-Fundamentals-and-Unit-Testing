namespace ExercisesSimpleCommands;

class Program
{
    static void Main(string[] args)
    {
        int FirstBase = int.Parse(Console.ReadLine());
        int SecondBase = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        int TrapezoidArea = (FirstBase + SecondBase) / 2 * height;
        Console.WriteLine(TrapezoidArea);
        
    }
}
