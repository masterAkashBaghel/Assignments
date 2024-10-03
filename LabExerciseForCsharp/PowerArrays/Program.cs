using System;

public class PowerArrays
{
    static int MOD = 1000000007;

    public static int powerArrays(int N, int K)
    {
        int[,] dp = new int[N + 1, K + 1];
        dp[0, 0] = 1;

        for (int i = 1; i <= N; i++)
        {
            for (int j = 0; j <= K; j++)
            {
                dp[i, j] = dp[i - 1, j];
                int power = 1;
                while (power <= j)
                {
                    dp[i, j] = (dp[i, j] + dp[i - 1, j - power]) % MOD;
                    power *= 2;
                }
            }
        }

        return dp[N, K];
    }

    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');
        int N = int.Parse(tokens[0]);
        int K = int.Parse(tokens[1]);

        Console.WriteLine(powerArrays(N, K));
    }
}