using System;

public class PasswordChecker
{
    public static void Main(string[] args)
    {
        string password = Console.ReadLine();

        if (password == "s3cr3t!")
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}