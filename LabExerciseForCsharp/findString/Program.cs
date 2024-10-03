using System;

public class findString
{
    public static void findTheString(int N)
    {
        // Generate the repeating sequence "abc"
        char[] result = new char[N];
        char[] pattern = { 'a', 'b', 'c' };

        for (int i = 0; i < N; i++)
        {
            result[i] = pattern[i % 3];
        }

        // Print the resulting string
        Console.WriteLine(new string(result));
    }

    public static void Main(string[] args)
    {
        // Read input
        int N = int.Parse(Console.ReadLine());

        // Find and print the string
        findTheString(N);
    }
}