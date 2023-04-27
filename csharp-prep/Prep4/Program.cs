using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Display instructions.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        // Declare the necessary variables.
        List<int> numbers = new List<int>();
        string givenNumberText;
        int givenNumber;

        do
        {
            // Get a number from the user.
            Console.Write("Enter number: ");
            givenNumberText = Console.ReadLine();
            givenNumber = int.Parse(givenNumberText);

            // Add the number to a list.
            numbers.Add(givenNumber);
        } while (givenNumber != 0);

        // Get the full sum of the numbers list.
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        // Get the average of the numbers list.
        double average = (double)sum / (numbers.Count - 1);

        // Get the largest number.
        int highestNumber = 0;

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                highestNumber = number;
            }
        }

        // Display the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number: {highestNumber}");
    }
}