using System;

class Program
{
    static void Main(){
        Scripture scripture = new Scripture();
        Verse verse = new Verse();
        verse.Load();
        verse.Display();
    }
}
