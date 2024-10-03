using System;
using System.Collections.Generic;

internal class cubeSquare
{
    // Function to precompute all perfect squares and cubes up to 1000
    static HashSet<int> PrecomputeSquaresAndCubes()
    {
        HashSet<int> squaresAndCubes = new HashSet<int>();

        for (int i = 1; i * i <= 1000; i++)
        {
            squaresAndCubes.Add(i * i);
        }

        for (int i = 1; i * i * i <= 1000; i++)
        {
            squaresAndCubes.Add(i * i * i);
        }

        return squaresAndCubes;
    }

    // Function to count the number of squares and cubes up to N
    static int cubeSquare(int N, HashSet<int> squaresAndCubes)
    {
        int count = 0;
        foreach (int num in squaresAndCubes)
        {
            if (num <= N)
            {
                count++;
            }
        }
        return count;
    }

    static void Main(string[] args)
    {
        // Precompute squares and cubes
        HashSet<int> squaresAndCubes = PrecomputeSquaresAndCubes();

        // Read number of test cases
        int T = int.Parse(Console.ReadLine());

        // Process each test case
        for (int t = 0; t < T; t++)
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(cubeSquare(N, squaresAndCubes));
        }
    }
}