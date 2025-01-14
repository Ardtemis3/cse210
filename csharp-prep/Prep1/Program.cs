using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.Write($"Your name is {last}, {first} {last}.");
    }
}

// //loops
// static void Week02(){
//     //while
//     int count = 0;
//     While (count <10){
//         Console.WriteLine($"Count is {count}");
//         count++;
//     }
//     //do while
//     string name;
//     do{
//         Console.WriteLine("Enter name");
//         name = Console.ReadLine();
//     } while

//     //for
//     string[] cars = {"volvo", "bmw", "ford", "mazda"}
//     foreach (string car in cars){
//         Console.WriteLine($"{car}");
//     }
// }