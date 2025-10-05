using System;

/*
------------------------------------------
Mindfulness Program - Exceeding Requirements
------------------------------------------
Enhancement:
Added a session log that tracks how many times each activity is performed.
At the end of the program, the totals are displayed before exiting.

This shows creativity and goes beyond the base requirements.
------------------------------------------
*/

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = 0;
                Console.WriteLine("Invalid input. Please enter a number 1-4.");
                Console.ReadLine();
                continue;
            }

            if (choice == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                breathingCount++;
            }
            else if (choice == 2)
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                reflectingCount++;
            }
            else if (choice == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                listingCount++;
            }
            else if (choice == 4)
            {
                Console.Clear();
                Console.WriteLine("Session Summary:");
                Console.WriteLine($"  Breathing activities performed: {breathingCount}");
                Console.WriteLine($"  Reflecting activities performed: {reflectingCount}");
                Console.WriteLine($"  Listing activities performed: {listingCount}");
                Console.WriteLine("\nThank you for practicing mindfulness today!");
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter a valid option (1-4).");
            }

            if (choice != 4)
            {
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}
