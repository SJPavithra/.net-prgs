using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operator (+, -, *, /):");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = op switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num1 / num2,
            _ => 0
        };

        Console.WriteLine($"Result: {result}");
    }
}
