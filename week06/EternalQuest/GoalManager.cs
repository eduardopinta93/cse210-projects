using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nCurrent Score: {_score} pts");

        int level = 1;
        if (_score >= 2000) level = 4;
        else if (_score >= 1000) level = 3;
        else if (_score >= 500) level = 2;

        Console.WriteLine($"Player Level: {level}");
    }


    
    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i]._shortName}");
        }
    }

    
    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (Goal g in _goals)
        {
            Console.WriteLine(g.GetDetailsString());
        }
    }

    
    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1-Simple 2-Eternal 3-Checklist");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1": 
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2": 
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3": 
                Console.Write("Enter target amount: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Select a goal number to record: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            int pointsEarned = _goals[choice].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    
    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            _score = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string type = parts[0];
                string name = parts[1];
                string desc = parts[2];
                int points = int.Parse(parts[3]);

                switch (type)
                {
                    case "SimpleGoal":
                        bool isComplete = bool.Parse(parts[4]);
                        SimpleGoal sg = new SimpleGoal(name, desc, points);
                        if (isComplete) sg.RecordEvent(); 
                        _goals.Add(sg);
                        break;

                    case "EternalGoal":
                        _goals.Add(new EternalGoal(name, desc, points));
                        break;

                    case "ChecklistGoal":
                        int amountCompleted = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        ChecklistGoal cg = new ChecklistGoal(name, desc, points, target, bonus);
                        for (int i = 0; i < amountCompleted; i++)
                            cg.RecordEvent(); 
                        _goals.Add(cg);
                        break;
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}
