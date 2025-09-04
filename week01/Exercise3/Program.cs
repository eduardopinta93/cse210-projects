using System;

class Program
{
    static void Main(string[] args)
    {
        Random myRandom = new Random();
        string playAgain = "yes";
        

        while(playAgain == "yes")

        {
            int number = myRandom.Next(1, 101);
            int count = 0;
            Console.WriteLine("Guess a number from 1 to 100!");
            int magicNumber = number;
        
            Console.WriteLine("What is your guess?");
            int guess = int.Parse(Console.ReadLine());

            while (magicNumber != guess)

            {
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    Console.WriteLine("What is your guess?");
                    guess = int.Parse(Console.ReadLine());
                    count++;
                }
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    Console.WriteLine("What is your guess?");
                    guess = int.Parse(Console.ReadLine());
                    count++;
                }
                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    count++;
                    Console.WriteLine($"It took you {count} attempts");
                    Console.WriteLine("Do you want to play again?");
                    playAgain = Console.ReadLine();
                }
            }
        }
    }
}