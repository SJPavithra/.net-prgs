using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Press Enter to start the stopwatch.");
        Console.ReadLine();
        DateTime start = DateTime.Now;

        Console.WriteLine("Press Enter to stop the stopwatch.");
        Console.ReadLine();
        DateTime stop = DateTime.Now;

        TimeSpan elapsed = stop - start;
        Console.WriteLine($"Elapsed time: {elapsed.Seconds} seconds.");
    }
}
