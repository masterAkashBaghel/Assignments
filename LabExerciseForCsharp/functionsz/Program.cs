using System;

public class functionsz
{
    // Function to compute the sum of the series
    public static int f(int A, int B, int N)
    {
        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            sum += A + i * B;
        }
        return sum;
    }

    public static void functionEq(int A, int B, int K, int P)
    {
        // Calculate f(K) and f(P)
        int fK = f(A, B, K);
        int fP = f(A, B, P);

        // Calculate the difference
        int result = fK - fP;

        // Print the result
        Console.WriteLine(result);
    }

    public static void Main(string[] args)
    {
        // Read input
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int P = int.Parse(Console.ReadLine());

        // Calculate and print the result
        functionEq(A, B, K, P);
    }
}