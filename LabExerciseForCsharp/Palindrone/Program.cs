using System;
using System.Collections.Generic;
using System.Linq;

public class PalindromeArray
{
    public static void Main(string[] args)
    {
        // Read input
        int N = int.Parse(Console.ReadLine());
        int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        // Find and print the palindrome array
        List<int> result = findPalindrome(N, A);
        Console.WriteLine(string.Join(" ", result));
    }

    public static List<int> findPalindrome(int N, int[] A)
    {
        // Dictionary to count the frequency of each element
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (int num in A)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }
        }

        // List to store the first half of the palindrome
        List<int> firstHalf = new List<int>();
        int middleElement = -1;

        // Sort the keys to ensure lexicographical order
        var sortedKeys = frequency.Keys.ToList();
        sortedKeys.Sort();

        // Construct the first half and identify the middle element if any
        foreach (int key in sortedKeys)
        {
            int count = frequency[key];
            for (int i = 0; i < count / 2; i++)
            {
                firstHalf.Add(key);
            }
            if (count % 2 != 0)
            {
                if (middleElement == -1 || key < middleElement)
                {
                    middleElement = key;
                }
            }
        }

        // Construct the second half by reversing the first half
        List<int> secondHalf = new List<int>(firstHalf);
        secondHalf.Reverse();

        // Combine the halves and the middle element if any
        List<int> palindrome = new List<int>(firstHalf);
        if (middleElement != -1)
        {
            palindrome.Add(middleElement);
        }
        palindrome.AddRange(secondHalf);

        return palindrome;
    }
}