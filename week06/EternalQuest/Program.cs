// Improvements beyond requirements:
// 1. Added "Display Player Info" option inside the main menu for better user experience.
// 2. Implemented a simple leveling system that increases player level based on total score.
//    Levels: 1 (0–499 pts), 2 (500–999 pts), 3 (1000–1999 pts), 4 (2000+ pts).
// These features make the program more interactive and rewarding for the user.


using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n=== Eternal Quest Menu ===");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Details");
            Console.WriteLine("3. Create a New Goal");
            Console.WriteLine("4. Record an Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.DisplayPlayerInfo();
                    break;
                case "2":
                    manager.ListGoalDetails();
                    break;
                case "3":
                    manager.CreateGoal();
                    break;
                case "4":
                    manager.RecordEvent();
                    break;
                case "5":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;
                case "6":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    break;
                case "7":
                    running = false;
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}
