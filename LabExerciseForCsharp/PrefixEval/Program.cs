using System;
using System.Collections.Generic;

public class PrefixEvaluation
{
    public static void Main(string[] args)
    {
        // Read input
        string S = Console.ReadLine();

        // Evaluate the prefix expression and print the result
        int result = prefixEvaluation(S);
        Console.WriteLine(result);
    }

    public static int prefixEvaluation(string S)
    {
        Stack<int> stack = new Stack<int>();

        // Iterate through the expression from right to left
        for (int i = S.Length - 1; i >= 0; i--)
        {
            char c = S[i];

            // If the character is an operand, push it onto the stack
            if (char.IsDigit(c))
            {
                stack.Push(c - '0');
            }
            // If the character is an operator, pop two operands from the stack, perform the operation, and push the result back onto the stack
            else
            {
                int operand1 = stack.Pop();
                int operand2 = stack.Pop();
                int result = 0;

                switch (c)
                {
                    case '+':
                        result = operand1 + operand2;
                        break;
                    case '-':
                        result = operand1 - operand2;
                        break;
                    case '*':
                        result = operand1 * operand2;
                        break;
                    case '/':
                        result = operand1 / operand2;
                        break;
                }

                stack.Push(result);
            }
        }

        // The result will be the only element left in the stack
        return stack.Pop();
    }
}