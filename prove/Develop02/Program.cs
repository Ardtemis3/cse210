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
        PromptManager promptManager = new PromptManager();
        promptManager.FillList();
        // do while loop
            // prompt, entry
    }
}
