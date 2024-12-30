using System;

class Program
{
    static int Factorial(int n)
    {
        return n == 0 ? 1 : n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Factorial: {Factorial(number)}");
    }
}
