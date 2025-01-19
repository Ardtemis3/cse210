using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the secret number? ");
        string secretNum = Console.ReadLine();
        int secret = int.Parse(secretNum);
        bool pass = false;
        int count = 0;
        while (pass == false){
            count ++;
            Console.WriteLine("What is your guess? ");
            string guessNum = Console.ReadLine();
            int guess = int.Parse(guessNum);
            if (guess == secret) {
                Console.WriteLine("You got it");
                Console.WriteLine($"You made {count} attempts.");
                pass = true;
                Console.WriteLine("Do you want to play again? ");
                string again = Console.ReadLine();
                if (again == "yes"){
                    pass = false;
                    // Console.Write("What is the secret number? ");
                    // string secretNum = Console.ReadLine();
                    // int secret = int.Parse(secretNum);
                }
            }
            else if (guess < secret) {
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("Lower");
            }
        }
    }
}