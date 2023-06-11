using System;

class Program
{
    static void Main(string[] args)
    {
        // Instances
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        // Main Loop
        Console.Clear();
        string input = "";
        while (input != "4")
        {
            // Interface
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start Breathing Activity");
            Console.WriteLine("    2. Start Reflection Activity");
            Console.WriteLine("    3. Start Listing Activity");
            Console.WriteLine("    4. Quit");
            Console.WriteLine("Select a choice from the menu by typing its number:");
            Console.Write("> ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    breathingActivity.RunActivity();
                    break;
                case "2":
                    reflectionActivity.RunActivity();
                    break;
                case "3":
                    listingActivity.RunActivity();
                    break;
            }
        }
    }
}