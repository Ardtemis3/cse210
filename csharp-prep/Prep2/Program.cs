using System;

class Grade
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percent? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        if (gradeNumber >= 90){
            Console.Write("Your grade is an A. ");
        }
        else if (gradeNumber >= 80){
            Console.Write("Your grade is an B. ");
        }
        else if (gradeNumber >= 70){
            Console.Write("Your grade is an C. ");
        }
        else if (gradeNumber >= 60){
            Console.Write("Your grade is an D. ");
        }
        else {
            Console.Write("Your grade is an F. ");
        }

    }
}