using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of Fibonacci terms:");
        int terms = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1, next;

        Console.WriteLine("Fibonacci Sequence:");
        for (int i = 0; i < terms; i++)
        {
            Console.Write($"{a} ");
            next = a + b;
            a = b;
            b = next;
        }
    }
}
