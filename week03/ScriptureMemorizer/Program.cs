// Creativity and Exceeding Requirements:
// To go beyond the core requirements of the assignment, this program now includes a small library of scriptures.
// Each time the program runs, it randomly selects one scripture from the library for the user to practice memorizing.
// This adds variety and makes the memorization challenge more engaging, instead of only using a single scripture.
// and desmostrate creativity beyond the basic task.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Reference> references = new List<Reference>
        {
            new Reference("Matthew", 3, 9),
            new Reference("John", 3, 16),
            new Reference("Proverbs", 3, 5, 6)
        };

        List<string> texts = new List<string>
        {
            "And think not to say within yourselves, We have Abraham to our father: for I say unto you, that God is able of these stones to raise up children unto Abraham",
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life",
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding"
        };

        Random rnd = new Random();
        int index = rnd.Next(references.Count);

        Scripture scripture = new Scripture(references[index], texts[index]);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(4);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}