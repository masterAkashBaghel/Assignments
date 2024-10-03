using System;

public class PureArray
{
    public static void Main(string[] args)
    {
        // Read the number of queries
        int Q = int.Parse(Console.ReadLine());

        for (int q = 0; q < Q; q++)
        {
            // Read the size of the array
            int N = int.Parse(Console.ReadLine());
            int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            // Determine if the array can be made pure and count the operations
            (bool canBePure, int operations) = pureArray(N, A);

            if (canBePure)
            {
                Console.WriteLine("YES");
                Console.WriteLine(operations);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }

    public static (bool, int) pureArray(int N, int[] A)
    {
        int operations = 0;

        for (int i = 0; i < N / 2; i++)
        {
            int left = A[i];
            int right = A[N - 1 - i];

            if (left == 0 && right == 0)
            {
                // Both are zeros, we can change both to any positive integer
                operations += 2;
            }
            else if (left == 0 || right == 0)
            {
                // One is zero, change it to match the other
                operations += 1;
            }
            else if (left != right)
            {
                // Both are non-zero and different, cannot make it a palindrome
                return (false, 0);
            }
        }

        // If the array length is odd, check the middle element
        if (N % 2 != 0 && A[N / 2] == 0)
        {
            operations += 1;
        }

        return (true, operations);
    }
}