using System;

public class countOfIntersection
{
    public static void numStudents(int A, int B, int C, int D, int E, int F, int G)
    {
        // Apply the inclusion-exclusion principle
        int allThree = G - A - B - C + D + E + F;
        Console.WriteLine(allThree);
    }

    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');
        int A = int.Parse(tokens[0]);
        int B = int.Parse(tokens[1]);
        int C = int.Parse(tokens[2]);
        int D = int.Parse(tokens[3]);
        int E = int.Parse(tokens[4]);
        int F = int.Parse(tokens[5]);
        int G = int.Parse(tokens[6]);

        numStudents(A, B, C, D, E, F, G);
    }
}