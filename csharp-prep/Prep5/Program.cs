using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string user_name = PromptUserName();
        int user_num = PromptUserNumber();
        
        int squared_num = SquareNumber(user_num);

        DisplayResult(user_name, squared_num);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program! ");
    }

    static string PromptUserName(){
        Console.WriteLine("Please enter your name: ");
        string user = Console.ReadLine();

        return user;
    }

    static int PromptUserNumber(){
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number){
        int squared = number * number;

        return squared;
    }

    static void DisplayResult(string user, int squared){
        Console.WriteLine($"{user}, the square of your number is {squared}.");
    }
}