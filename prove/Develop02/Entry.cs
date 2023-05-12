using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string _title;
    public DateTime currentDate = DateTime.Now;
    public string _dateText;
    string _prompt;
    string _text;

    public string WriteEntry(string prompt)
    {
        // Get the date in a string
        _dateText = currentDate.ToShortDateString();

        // Get a prompt?
        Console.WriteLine("\nWould you like to use a prompt? [y/n]");
        Console.Write("> ");
        string usePrompt = Console.ReadLine();
        if (usePrompt == "y")
        {
            UsePrompt(prompt);
        }
        else
        {
            DoNotUsePrompt();
        }

        // Get text of the entry given by the user
        Console.Write("> ");
        _text = Console.ReadLine();

        // Get the title of the entry given by the user
        Console.WriteLine("\nEnter the title of your entry: ");
        Console.Write("> ");
        _title = Console.ReadLine();

        // Retrun the entire entry as a concatenated string
        return $"--- {_title} ---\nDate: {_dateText} — Prompt: {_prompt}\n{_text}\n";
    }

    public void UsePrompt(string prompt)
    {
        Console.WriteLine("\nUse a custom prompt? [y/n]");
        Console.Write("> ");
        string useCustomPrompt = Console.ReadLine();

        if (useCustomPrompt == "y")
        {
            Console.WriteLine("\nWrite your own prompt.");
            Console.Write("> ");
            _prompt = Console.ReadLine();
        }
        else
        {
            _prompt = prompt;
        }

        Console.WriteLine($"\nPrompt: {_prompt}");
    }

    public void DoNotUsePrompt()
    {
        _prompt = "None";
        Console.WriteLine("\nWrite your entry: ");
    }
}