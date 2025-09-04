using System;

class Program
{
    static void Main(string[] args)
    {
        string lettery;
        Console.WriteLine("Hello, what is your grade percentage?");
        int percentage = int.Parse(Console.ReadLine());
        int lastDigit = percentage % 10;

        if (percentage >= 90)
        {
            lettery = "A";
            if (lastDigit < 3)
            {
                lettery = "A-";
            }
        }
        else if (percentage >= 80)
        {
            lettery = "B";
            if (lastDigit < 3)
            {
                lettery = "B-";
            }
            else if (lastDigit >= 7)
            {
                lettery = "B+";
            }
        }
        else if (percentage >= 70)
        {
            lettery = "C";
            if (lastDigit < 3)
            {
                lettery = "C-";
            }
            else if (lastDigit >= 7)
            {
                lettery = "C+";
            }
        }
        else if (percentage >= 60)
        {
            lettery = "D";
             if (lastDigit < 3)
            {
                lettery = "D-";
            }
            else if (lastDigit >= 7)
            {
                lettery = "D+";
            }
        }
        else
        {
            lettery = "F";
        }

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulation you passed the course!");
            Console.WriteLine($"Your grade is {lettery}");
        }
        else
        {
            Console.WriteLine("You did not pass the course, work harder");
            Console.WriteLine($"Your grade is {lettery}");
        }
    }
}