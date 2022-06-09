// See https://aka.ms/new-console-template for more information
using System;
class Programs
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int actual = rnd.Next(100);
        int guess;

        Console.WriteLine("************RANDOM NUMBER GUESSING GAME*************************");
        Console.WriteLine();

        do
        {
            Console.Write("Guess a number between 1 and 100: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < actual)
            {
                Console.WriteLine("Number GREATER than " + guess + ".");
            }
            if (guess > actual)
            {
                Console.WriteLine("Number LOWER than " + guess + ".");
            }
            Console.WriteLine();
        }
        while (guess != actual);

        if (guess == actual)
        {
            Console.WriteLine("Congratulations!! the number was " + actual);
        }
        Console.WriteLine("\nPress ANY key to end!");
        Console.ReadKey();
    }
}
