using System;

public class Loopings
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Display numbers in reverse order from 50 to 1");
        Console.WriteLine("2. Display odd numbers between 1 to 50");
        Console.WriteLine("3. Display even numbers between 1 to 50");
        Console.WriteLine("4. Print table of a given number");
        Console.WriteLine("5. Find out even numbers from a given array");
        Console.WriteLine("Enter your choice (1-5):");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                DisplayNumbersInReverse();
                break;
            case 2:
                DisplayOddNumbers();
                break;
            case 3:
                DisplayEvenNumbers();
                break;
            case 4:
                PrintTableOfGivenNumber();
                break;
            case 5:
                FindEvenNumbersInArray();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    public static void DisplayNumbersInReverse()
    {
        for (int i = 50; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }

    public static void DisplayOddNumbers()
    {
        int i = 1;
        do
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
            i++;
        } while (i <= 50);
    }

    public static void DisplayEvenNumbers()
    {
        int i = 1;
        while (i <= 50)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }

    public static void PrintTableOfGivenNumber()
    {
        Console.WriteLine("Enter a number to print its table:");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }

    public static void FindEvenNumbersInArray()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Even numbers in the array are:");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}