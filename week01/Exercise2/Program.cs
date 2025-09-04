using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        Console.WriteLine("Hello, what is your grade percentage?");
        int percentage = int.Parse(Console.ReadLine());
        int lastDigit = percentage % 10;

        if (percentage >= 90)
        {
            letter = "A";
            if (lastDigit < 3)
            {
                letter = "A-";
            }
        }
        else if (percentage >= 80)
        {
            letter = "B";
            if (lastDigit < 3)
            {
                letter = "B-";
            }
            else if (lastDigit >= 7)
            {
                letter = "B+";
            }
        }
        else if (percentage >= 70)
        {
            letter = "C";
            if (lastDigit < 3)
            {
                letter = "C-";
            }
            else if (lastDigit >= 7)
            {
                letter = "C+";
            }
        }
        else if (percentage >= 60)
        {
            letter = "D";
             if (lastDigit < 3)
            {
                letter = "D-";
            }
            else if (lastDigit >= 7)
            {
                letter = "D+";
            }
        }
        else
        {
            letter = "F";
        }

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulation you passed the course!");
            Console.WriteLine($"Your grade is {letter}");
        }
        else
        {
            Console.WriteLine("You did not pass the course, work harder");
            Console.WriteLine($"Your grade is {letter}");
        }
    }
}