using System;

public class ORSum
{
    public static void Main(string[] args)
    {
        // Read input
        int N = int.Parse(Console.ReadLine());
        int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        // Find and print the sum of all bitwise OR
        int result = orSum(N, A);
        Console.WriteLine(result);
    }

    public static int orSum(int N, int[] A)
    {
        int totalSum = 0;

        // Iterate through all possible subsequences using bit manipulation
        int totalSubsequences = 1 << N; // 2^N subsequences
        for (int mask = 1; mask < totalSubsequences; mask++)
        {
            int currentOR = 0;
            for (int i = 0; i < N; i++)
            {
                if ((mask & (1 << i)) != 0)
                {
                    currentOR |= A[i];
                }
            }
            totalSum += currentOR;
        }

        return totalSum;
    }
}