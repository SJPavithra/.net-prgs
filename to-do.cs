using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();
        string input;

        do
        {
            Console.WriteLine("\nEnter 'add' to add a task, 'view' to see tasks, or 'exit' to quit:");
            input = Console.ReadLine();

            if (input == "add")
            {
                Console.WriteLine("Enter task:");
                tasks.Add(Console.ReadLine());
            }
            else if (input == "view")
            {
                Console.WriteLine("\nTasks:");
                tasks.ForEach(Console.WriteLine);
            }

        } while (input != "exit");
    }
}
