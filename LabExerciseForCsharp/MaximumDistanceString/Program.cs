using System;

public class MinimumDistanceStrings
{
    public static void Main(string[] args)
    {
        // Read input
        string S = Console.ReadLine();
        int K = int.Parse(Console.ReadLine());

        // Find and print the smallest lexicographical string S1
        string result = minDistanceString(S, K);
        Console.WriteLine(result);
    }

    public static string minDistanceString(string S, int K)
    {
        char[] S1 = new char[S.Length];
        int remainingDistance = K;

        for (int i = 0; i < S.Length; i++)
        {
            int distanceToA = S[i] - 'a';
            int distanceToZ = 'z' - S[i];

            if (remainingDistance >= distanceToA)
            {
                S1[i] = 'a';
                remainingDistance -= distanceToA;
            }
            else if (remainingDistance >= distanceToZ)
            {
                S1[i] = 'z';
                remainingDistance -= distanceToZ;
            }
            else
            {
                S1[i] = (char)(S[i] + remainingDistance);
                remainingDistance = 0;
            }
        }

        if (remainingDistance > 0)
        {
            return "-1";
        }

        return new string(S1);
    }
}