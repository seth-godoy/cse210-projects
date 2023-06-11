using System;
using System.Collections.Generic;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private List<string> _loadingList = new List<string>();
    protected Random _random = new Random();

    public Activity()
    {
        FillLoadingList();
    }

    private void FillLoadingList()
    {
        _loadingList.Add("|");
        _loadingList.Add("/");
        _loadingList.Add("—");
        _loadingList.Add("\\");
    }

    protected void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");

        Console.WriteLine("How long, in seconds, would you like your session?");
        Console.Write("> ");
        string durationText = Console.ReadLine();
        _duration = int.Parse(durationText);

        Console.Clear();
        Console.Write("Get ready... ");
        DisplayLoadingAnimation(5);
        Console.WriteLine("\n");
    }

    protected void EndActivity()
    {
        Console.WriteLine("Well done!!");
        DisplayLoadingAnimation(5);
        Console.WriteLine();
        Console.WriteLine($"You've completed {_duration} seconds of the {_name} Activity.");
        DisplayLoadingAnimation(5);
        Console.Clear();
    }

    public void DisplayLoadingAnimation(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(_loadingList[i]);
            Thread.Sleep(333);
            Console.Write("\b \b");

            i++;

            if (i >= _loadingList.Count)
            {
                i = 0;
            }
        }
    }

    public void DisplayCountdown(int seconds) 
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}