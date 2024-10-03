using System;

public class StringHandling
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Search for a word in a given string");
        Console.WriteLine("2. Split a string using comma and print each value on a separate line");
        Console.WriteLine("Enter your choice (1 or 2):");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                SearchWordInString();
                break;
            case 2:
                SplitStringByComma();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    public static void SearchWordInString()
    {
        Console.WriteLine("Enter the string:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Enter the word to search:");
        string wordToSearch = Console.ReadLine();

        if (inputString.Contains(wordToSearch))
        {
            Console.WriteLine($"The word '{wordToSearch}' is found in the given string.");
        }
        else
        {
            Console.WriteLine($"The word '{wordToSearch}' is not found in the given string.");
        }
    }

    public static void SplitStringByComma()
    {
        Console.WriteLine("Enter the string to split by comma:");
        string inputString = Console.ReadLine();

        string[] values = inputString.Split(',');

        Console.WriteLine("The values are:");
        foreach (string value in values)
        {
            Console.WriteLine(value.Trim());
        }
    }
}