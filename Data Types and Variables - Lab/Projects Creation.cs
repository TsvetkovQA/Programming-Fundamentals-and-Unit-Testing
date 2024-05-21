using System;

public class ProjectCreationTime
{
    public static void Main(string[] args)
    {
        string architectName = Console.ReadLine();
        int projectCount = Convert.ToInt32(Console.ReadLine());
        const int hoursPerProject = 3;
        int totalHours = projectCount * hoursPerProject;
        Console.WriteLine($"The architect {architectName} will need {totalHours} hours to complete {projectCount} project/s.");
    }
}