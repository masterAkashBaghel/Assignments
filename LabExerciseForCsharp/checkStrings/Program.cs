using System;

public class checkString
{
    public static void string_check(int N, string[] testCases)
    {
        for (int t = 0; t < N; t++)
        {
            string s = testCases[t];
            int minLength = int.MaxValue;
            bool found = false;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    string substring = s.Substring(i, j - i + 1);
                    int countHash = 0, countZeroOne = 0;

                    foreach (char c in substring)
                    {
                        if (c == '#') countHash++;
                        else if (c == '0' || c == '1') countZeroOne++;
                    }

                    if (countHash > countZeroOne)
                    {
                        minLength = Math.Min(minLength, substring.Length);
                        found = true;
                    }
                }
            }

            if (found)
                Console.WriteLine(minLength);
            else
                Console.WriteLine(-1);
        }
    }

    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] testCases = new string[N];

        for (int i = 0; i < N; i++)
        {
            int arr_size = int.Parse(Console.ReadLine());
            testCases[i] = Console.ReadLine();
        }

        string_check(N, testCases);
    }
}