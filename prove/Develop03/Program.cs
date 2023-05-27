using System;

class Program
{
    static void Main(string[] args)
    {
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, text);

        string input = "";
        while (input != "quit")
        {
            Console.Clear();
            scripture.DisplayScripture();

            if (scripture.AllWordsHidden())
            {
                break;
            }

            Console.WriteLine("\nPress enter to continue. Type 'quit' to finish.\nType 'go back' to show previously hidden words.");
            Console.Write("> ");
            input = Console.ReadLine();

            if (input == "go back")
            {
                scripture.ShowRandomWord();
                scripture.ShowRandomWord();
            }
            else
            {
                scripture.HideRandomWord();
                scripture.HideRandomWord();                
            }
        }

        Console.WriteLine();
    }
}