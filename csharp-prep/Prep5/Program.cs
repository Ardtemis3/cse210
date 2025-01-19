using System;
using System.Configuration.Assemblies;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program");
        Console.WriteLine("What is your name");
        string name = Console.ReadLine();
        Console.WriteLine("What is your favorite number? ");
        string favNum = Console.ReadLine();
        float num = float.Parse(favNum);
        float squareNum = num * num;
        Console.WriteLine($"Your favorite number is {num} and it squared is {squareNum}.");
    }
}