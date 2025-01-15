using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Instructions for the user
        Console.WriteLine("Enter the numbers you want to sum, separated by spaces:");

        // Read user input
        string input = Console.ReadLine();

        // Convert the input into a list of integers
        List<int> numbers = new List<int>();
        foreach (var item in input.Split(' '))
        {
            if (int.TryParse(item, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine($"'{item}' is not a valid number and will be ignored.");
            }
        }

        // Calculate the sum
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        // Display the result
        Console.WriteLine($"The sum of the numbers is: {sum}");
    }
}
