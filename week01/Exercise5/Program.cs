using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);


    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name:");
        string givenName = Console.ReadLine();
        return givenName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:");
        int givenNum = int.Parse(Console.ReadLine());
        return givenNum;
    }
    static int SquareNumber(int UserNum)
    {
        int square = UserNum * UserNum;
        return square;
    }
    static void DisplayResult(string UserName, int number)
    {
        Console.WriteLine($"{UserName}, the square of your number is: {number}");
    }
}