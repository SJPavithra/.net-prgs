using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter temperature:");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Convert to (C/F):");
        char choice = Console.ReadKey().KeyChar;

        if (choice == 'C' || choice == 'c')
        {
            double celsius = (temp - 32) * 5 / 9;
            Console.WriteLine($"\nTemperature in Celsius: {celsius}°C");
        }
        else if (choice == 'F' || choice == 'f')
        {
            double fahrenheit = (temp * 9 / 5) + 32;
            Console.WriteLine($"\nTemperature in Fahrenheit: {fahrenheit}°F");
        }
        else
        {
            Console.WriteLine("\nInvalid option!");
        }
    }
}
