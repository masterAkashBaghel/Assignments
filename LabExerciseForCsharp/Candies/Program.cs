using System;
using System.Linq;

public class Candies
{
    public static void minMaxCandies(int N, int[] prices, int K)
    {
        Array.Sort(prices);

        // Calculate minimum cost
        int minCost = 0;
        int i = 0;
        while (i < N)
        {
            minCost += prices[i];
            i += (K + 1);
        }

        // Calculate maximum cost
        int maxCost = 0;
        int j = N - 1;
        while (j >= 0)
        {
            maxCost += prices[j];
            j -= (K + 1);
        }

        Console.WriteLine($"{minCost} {maxCost}");
    }

    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int K = int.Parse(Console.ReadLine());

        minMaxCandies(N, prices, K);
    }
}
