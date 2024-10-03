using System;
using System.Linq;

public class easyTeam
{
    public static void essayTeam(int N, int K, int[] attempts)
    {
        // Filter students who can participate at least K times
        int eligibleStudents = attempts.Count(attempt => attempt >= K);

        // Calculate the maximum number of teams
        int maxTeams = eligibleStudents / 3;

        Console.WriteLine(maxTeams);
    }

    public static void Main(string[] args)
    {
        // Read input
        string[] firstLine = Console.ReadLine().Split(' ');
        int N = int.Parse(firstLine[0]);
        int K = int.Parse(firstLine[1]);

        int[] attempts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        // Calculate and print the maximum number of teams
        essayTeam(N, K, attempts);
    }
}