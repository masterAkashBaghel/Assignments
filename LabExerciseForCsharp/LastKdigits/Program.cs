using System;

public class LastKdigits
{
    // Function to compute the last K digits of A^B
    public static void LastKdigits(int A, int B, int K)
    {
        // Calculate the modulus
        long modulus = (long)Math.Pow(10, K);

        // Compute A^B % 10^K using modular exponentiation
        long result = 1;
        for (int i = 0; i < B; i++)
        {
            result = (result * A) % modulus;
        }

        // Convert the result to a string and extract the last K digits
        string resultStr = result.ToString().PadLeft(K, '0');
        for (int i = resultStr.Length - K; i < resultStr.Length; i++)
        {
            Console.Write(resultStr[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        // Read input
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int K = int.Parse(input[2]);

        // Calculate and print the last K digits
        LastKdigits(A, B, K);
    }
}