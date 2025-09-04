using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();
        int sum = 0;
        double count = 0;
        int largest = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number:");
            int userNum = int.Parse(Console.ReadLine());
            if (userNum != 0)
            {
                numbersList.Add(userNum);
            }
            else
            {
                break;
            }
        }

        foreach (int i in numbersList)
        {
            sum = sum + i;
            count++;
            if (i > largest)
            {
                largest = i;
            }
        }
        double average = sum / count;
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is:{largest}");
    }
}