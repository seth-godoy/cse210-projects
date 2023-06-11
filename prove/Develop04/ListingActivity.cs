using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _items = new List<string>();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        FillPromptList();
    }

    private void FillPromptList()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void RunActivity()
    {
        StartActivity();
        DisplayPrompt();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            AddResponse();
        }

        DisplayItemCount();
        EndActivity();
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as can to the following prompt:\n");
        Console.WriteLine($"--- {_prompts[_random.Next(0, _prompts.Count)]} ---\n");

        Console.Write("You may begin in: ");
        DisplayCountdown(5);
        Console.WriteLine();
    }

    private void AddResponse()
    {
        Console.Write("> ");
        string response = Console.ReadLine();
        _items.Add(response);
    }

    private void DisplayItemCount()
    {
        Console.WriteLine($"You listed {_items.Count} items!");
        _items.Clear();
        Console.WriteLine();
    }
}