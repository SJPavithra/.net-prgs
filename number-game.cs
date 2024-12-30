using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int number = rand.Next(1, 101);
        int guess;

        Console.WriteLine("Guess the number between 1 and 100:");

        do
        {
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess < number) Console.WriteLine("Too low!");
            else if (guess > number) Console.WriteLine("Too high!");
        } while (guess != number);

        Console.WriteLine("Congratulations! You guessed it!");
    }
}
