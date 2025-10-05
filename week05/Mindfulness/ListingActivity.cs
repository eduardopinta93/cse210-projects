using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    
    private int _count;
    private List<string> _prompts;
    private Random _random;

    
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _random = new Random();

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($">>> {GetRandomPrompt()} <<<");
        Console.WriteLine("\nYou may begin in:");
        ShowCountDown(5);

        List<string> responses = GetListFromUser();

        _count = responses.Count;

        Console.WriteLine($"\nYou listed {_count} items!");
        ShowSpinner(3);

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        return responses;
    }
}
