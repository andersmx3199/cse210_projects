using System;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1,100);

        int guess_num = -1;

        while (guess_num != magic_num) {
            Console.WriteLine("What is your guess? ");
            guess_num = int.Parse(Console.ReadLine());

            if (guess_num < magic_num){
                Console.WriteLine("Higher");
            }
            else if (guess_num > magic_num){
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("You guessed it! ");
            }
            
        }
    }
}