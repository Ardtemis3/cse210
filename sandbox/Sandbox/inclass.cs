// Shopping cart
/*
Nouns (variables)
=====
-cart
-item
    -price
    -amount
    -name
    -checked (bool)
-total ?
========


Verbs (functions)
=======
-add
-exit
-remove
-check items
-display
========
*/

using System.Numerics;

class program{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the shopping cart program!\n");
        
        List<string> names = new List<string>() {"Milk", {"Bread"}};
        List<double> prices = new List<double>() {1.23, 3.34};

        bool done = false;
        while(!done){
            DisplayMenu();
            string choice = GetChoice();

            if (choice == "1"){
                Add();
            } else if (choice == "2"){
                Remove();
            }else if (choice == "3"){
                DisplayMenu();
            }else if (choice == "4"){
                Console.WriteLine($"Total = {total}");
            }else if (choice == "5"){
                done = true;
            }else{
                Console.WriteLine("Invalid Choice");
            }

        }
        

        // functions need to do 1 thing!!!!!!!!
        // objects are 1 thing !!!!!!!!

    }
    static void DisplayMenu(){
        Console.WriteLine("1) Add");
        Console.WriteLine("2) Remove");
        Console.WriteLine("3) Display");
        Console.WriteLine("4) Total");
        Console.WriteLine("5) Quite\n");
    }
    static string GetChoice(){
        Console.Write("Enter choice");
        string choice = Console.ReadLine();
        return choice;
    }
    static void Add(List<string> names, List<double> prices){
        // assume: prompt user, add to lists
        Console.Write("Enter name of item: ");
        string name = Console.ReadLine();

        Console.Write("Enter the price of item: ");
        string priceString = Console.ReadLine();
        double price = Convert.ToDouble(priceString);
        names.Add(name);
        prices.Add(price);
    }
    static double CalcTotal(List<double> prices){
        double total = 0;
        foreach(var price:double in prices){
            total += prices;
        }

    }
    static void Remove(){

    }
  
    static void Display(List<string> names, List<double> prices){
            Console.WriteLine("Cart");
            Console.WriteLine("======================");

            for(int i =0; i<names.Count; i++){
                Console.WriteLine($"{names[i],10}: {prices[i]}");
            }
    }
}