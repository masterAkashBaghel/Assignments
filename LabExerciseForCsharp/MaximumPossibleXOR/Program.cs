using System;
using System.Linq;

public class MaximumPossibleXOR
{
    public static void Main(string[] args)
    {
        // Read the array size and the number of queries
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());

        // Read the array elements
        int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        // Read the queries
        int[,] queries = new int[M, 2];
        for (int i = 0; i < M; i++)
        {
            string[] query = Console.ReadLine().Split(' ');
            queries[i, 0] = int.Parse(query[0]);
            queries[i, 1] = int.Parse(query[1]);
        }

        // Process each query and print the result
        int[] results = maxXorPair(N, M, A, queries);
        foreach (int result in results)
        {
            Console.WriteLine(result);
        }
    }

    public static int[] maxXorPair(int N, int M, int[] A, int[,] queries)
    {
        int[] results = new int[M];

        for (int q = 0; q < M; q++)
        {
            int L = queries[q, 0] - 1; // Convert to 0-based index
            int R = queries[q, 1] - 1; // Convert to 0-based index

            int maxXor = int.MinValue;
            int maxIndex = L;

            for (int i = L; i < R; i++)
            {
                int xorValue = A[i] ^ A[i + 1];
                if (xorValue > maxXor)
                {
                    maxXor = xorValue;
                    maxIndex = i + 1; // Convert back to 1-based index
                }
            }

            results[q] = maxIndex;
        }

        return results;
    }
}

