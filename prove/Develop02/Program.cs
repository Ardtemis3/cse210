using System;
using System.Xml.Serialization;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Develop02 World!");
        // create menu, promptman, journal
        Menu menu = new Menu();
        Journal journal = new Journal();
        journal.AddEntry("12/12/1232", "ergreg", "response");


        PromptManager promptManager = new PromptManager();
        string prompt = promptManager.GetRandomPrompt();

        System.Console.WriteLine(prompt);
        string reponse = System.Console.ReadLine();

        menu.Display();
        string choice = System.Console.ReadLine();

        promptManager.FillList();
        // do while loop
            // prompt, entry
    }
}
