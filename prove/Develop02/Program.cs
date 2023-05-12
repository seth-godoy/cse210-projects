using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Journal Program!\n");

        Entry entry = new Entry();
        string newEntry;

        Journal journal = new  Journal();
        journal.populatePrompts();

        string userNumber = "";
        while (userNumber != "5")
        {
            // Display Interface
            Console.WriteLine("Select one of the following choices by entering its number:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("> ");
            userNumber = Console.ReadLine();

            // 1. Write
            if (userNumber == "1")
            {
                // Pass a random prompt to write a new entry and add it to the journal
                newEntry = entry.WriteEntry(journal.GeneratePrompt());
                journal._entries.Add(newEntry);

                Console.WriteLine();
            }
            // 2. Display
            else if (userNumber == "2")
            {
                journal.DisplayJournal();
            }
            // 3. Load
            else if (userNumber == "3")
            {
                journal.LoadJournal();
            }
            // 4. Save
            else if (userNumber == "4")
            {
                journal.SaveJournal();
            }
            // 5. Quit (or continue loop if the user enters something else)
            else
            {
                // Do nothing
            }

        }

        Console.WriteLine();
    }
}