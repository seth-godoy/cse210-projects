using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunActivity()
    {
        StartActivity();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            TakeBreath();
        }

        EndActivity();
    }

    private void TakeBreath()
    {
        Console.Write("Breathe in... ");
        DisplayCountdown(5);
        Console.WriteLine();

        Console.Write("Now breathe out... ");
        DisplayCountdown(5);
        Console.WriteLine("\n");
    }
}