using System;
using System.Reflection.Metadata.Ecma335;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        // create menu, promptman, journal
        Journal journal = new Journal();
        Menu menu = new Menu();
        // journal.AddEntry("12/12/1232", "ergreg", "response");

        PromptManager promptManager = new PromptManager();
        string choice = "1";
        promptManager.FillList();
        // string prompt = promptManager.GetRandomPrompt();

        // System.Console.WriteLine(prompt);
        // string reponse = System.Console.ReadLine();

        // do while loop
            // prompt, entry
            do {
                menu.Display();
                choice = System.Console.ReadLine();
                switch (choice){
                    case "1": //write
                        NewEntry(promptManager, journal);
                        break;
                    case "2": //display
                        journal.Display();
                        break;
                    case "3": //save
                        journal.SaveEntry();
                        break;
                    case "4": //load
                        journal.LoadEntry();
                        break;
                }
            } while(choice != "5");

    }
    static void NewEntry(PromptManager promptManager, Journal journal){
        string prompt = promptManager.GetRandomPrompt();
        System.Console.WriteLine(prompt);
        string response = System.Console.ReadLine();
        DateTime now = DateTime.Now;
        string formattedDate = DateTime.Now.ToString("dd/MM/yyyy");
        journal.AddEntry(formattedDate, prompt, response);
    }


}
