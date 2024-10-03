using System;

public class Operators
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Decide whether a number is negative or positive using if-else");
        Console.WriteLine("2. Decide grade based on percentage using if-else if-else");
        Console.WriteLine("3. Display name of day from input 1-7 using switch case");
        Console.WriteLine("4. Decide whether a number is negative or positive using ternary operator");
        Console.WriteLine("Enter your choice (1-4):");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CheckNumberIfElse();
                break;
            case 2:
                DecideGrade();
                break;
            case 3:
                DisplayDayOfWeek();
                break;
            case 4:
                CheckNumberTernary();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    public static void CheckNumberIfElse()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is negative.");
        }
    }

    public static void DecideGrade()
    {
        Console.WriteLine("Enter the percentage:");
        int percentage = int.Parse(Console.ReadLine());

        if (percentage >= 70)
        {
            Console.WriteLine("Grade: A");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("Grade: B");
        }
        else if (percentage >= 50)
        {
            Console.WriteLine("Grade: C");
        }
        else if (percentage >= 40)
        {
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }
    }

    public static void DisplayDayOfWeek()
    {
        Console.WriteLine("Enter a number (1-7):");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

    public static void CheckNumberTernary()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        string result = number >= 0 ? "The number is positive." : "The number is negative.";
        Console.WriteLine(result);
    }
}