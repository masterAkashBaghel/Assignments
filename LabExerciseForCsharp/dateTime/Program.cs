using System;

internal class dateTime
{
    // Function to accept day, month, and year from user and construct a new date
    static DateTime ConstructDate()
    {
        Console.WriteLine("Enter day:");
        int day = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter month:");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter year:");
        int year = int.Parse(Console.ReadLine());

        DateTime date = new DateTime(year, month, day);
        Console.WriteLine($"Constructed Date: {date.ToShortDateString()}");
        return date;
    }

    // Function to accept two dates from user as strings and calculate the difference in days
    static void CalculateDateDifference()
    {
        Console.WriteLine("Enter the first date (yyyy-MM-dd):");
        string date1Str = Console.ReadLine();
        DateTime date1 = DateTime.Parse(date1Str);

        Console.WriteLine("Enter the second date (yyyy-MM-dd):");
        string date2Str = Console.ReadLine();
        DateTime date2 = DateTime.Parse(date2Str);

        TimeSpan difference = date2 - date1;
        Console.WriteLine($"Difference between dates: {difference.Days} days");
    }

    static void Main(string[] args)
    {
        // Construct a new date
        ConstructDate();

        // Calculate the difference between two dates
        CalculateDateDifference();
    }
}