using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<string> _entries = new List<string>();
    public List<string> _prompts = new List<string>();
    public Random _randomGeneretor = new Random();

    public void populatePrompts()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What was the worst part of my day?");
        _prompts.Add("What new things did I learn today?");
        _prompts.Add("What did I do today to get one step closer to my goal?");
        _prompts.Add("What did I do today to improve as a person?");
        _prompts.Add("What's the weirdest thing that happened to me today?");
    }

    public string GeneratePrompt()
    {
        return _prompts[_randomGeneretor.Next(0, 11)];
    }

    public void DisplayJournal()
    {
        Console.WriteLine();
        foreach (string line in _entries)
        {
            Console.WriteLine(line);
        }
    }

    public void LoadJournal()
    {
        Console.WriteLine("\nWhat is the file name?");
        Console.Write(">");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            _entries.Add(line);
        }

        Console.WriteLine();
    }

    public void SaveJournal()
    {
        Console.WriteLine("\nWhat is the file name?");
        Console.Write(">");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string line in _entries)
            {
                outputFile.WriteLine(line);
            }
        }

        Console.WriteLine();
    }
}