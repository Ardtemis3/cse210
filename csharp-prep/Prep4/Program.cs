using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when done.");
        // Console.WriteLine("enter a number: ");
        // string list = Console.ReadLine();
        // int listNum = int.Parse(list);
        float sum = -1;
        float count = -1;
        int high = 0;
        int listNum = 1;
        while (listNum != 0){
            sum += listNum;
            count+= 1;
            Console.WriteLine("enter a number: ");
            string list = Console.ReadLine();
            int listNumber = int.Parse(list);
            listNum = listNumber;
            if (listNum > high) {
                high = listNum;
            }
        }
        float average = sum / count;
        Console.WriteLine($"The sum = {sum}");
        Console.WriteLine($"The average = {average}");
        Console.WriteLine($"The highest number = {high}");
    }
}