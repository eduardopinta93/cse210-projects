using System;
using System.Security.Cryptography.X509Certificates;
// ==========================================================
// Exceeding Requirements Notes:
// 1. Added confirmation messages for all user actions:
//    - "Your entry has been added!"
//    - "Your Journal Entries:"
//    - "Journal loaded successfully!"
//    - "Journal saved successfully!"
//    These messages improve user feedback, not required in core specs.
// 2. Each journal entry now also saves the exact time along with the date.
//    This adds extra information to help the user track their day more precisely.
// ==========================================================


class Program
{
    static void Main(string[] args)
    {
        PromptGenerator PromptGenerator = new PromptGenerator();
        Journal Journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = PromptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);

                    string response = Console.ReadLine();

                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToString("g");
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;

                    Journal.AddEntry(newEntry);
                    Console.WriteLine("Your entry has been added!\n");  //
                    break;
                case "2":
                    Console.WriteLine("\nYour Journal Entries:"); //
                    Journal.DisplayAll();
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine("Enter the filename to load from: ");
                    string loadFile = Console.ReadLine();
                    Journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded successfully!\n"); //
                    break;
                case "4":
                    Console.WriteLine("Enter the filename to save to: ");
                    string saveFile = Console.ReadLine();
                    Journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved successfully!\n"); //
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
