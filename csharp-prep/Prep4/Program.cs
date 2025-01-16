using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        
        List<int> numbers = new List<int>();

        int number = -1;
        
        while (number != 0){
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        int num_total = 0;
        Console.WriteLine(" ");
        foreach (int num in numbers){
            num_total += num;
        }
        Console.WriteLine($"Sum is: {num_total}");
       

        float average = ((float)num_total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int max = numbers[0];

        foreach (int num in numbers){
            if (num > max){
                max = num;
            }
        }
        Console.WriteLine($"Max Value is: {max}");
    }
}