using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();
        string reversed = new string(word.Reverse().ToArray());

        Console.WriteLine(word.Equals(reversed, StringComparison.OrdinalIgnoreCase) ? "Palindrome" : "Not a Palindrome");
    }
}
