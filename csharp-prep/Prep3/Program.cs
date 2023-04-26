using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the magic number, which should be random
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // Declare the variables needed for user input
        string guessText;
        int guess;

        do
        {
            // Ask the user for a guess and tranform the guess string into an int
            Console.Write("What is your guess? ");
            guessText = Console.ReadLine();
            guess = int.Parse(guessText);

            // Check if magicNumber is higher, lower or equal to guess
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        
        // While the guess isn't the same as the magic, continue the loop
        } while (guess != magicNumber);
    }
}