using System;

public class NicePair
{
    public static void Main(string[] args)
    {
        // Read input
        string S = Console.ReadLine();

        // Find and print the number of nice pairs
        int result = nicePair(S);
        Console.WriteLine(result);
    }

    public static int nicePair(string S)
    {
        int count = 0;

        // Iterate through the string with two nested loops
        for (int i = 0; i < S.Length; i++)
        {
            for (int j = i + 1; j < S.Length; j++)
            {
                if (S[i] == 'a' && S[j] == 'b')
                {
                    count++;
                }
            }
        }

        return count;
    }
}