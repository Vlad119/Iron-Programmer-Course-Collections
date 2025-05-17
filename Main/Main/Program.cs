using System;
using System.Collections.Generic;

class Program
{
    static void Main()
        //проверка на скобки
    {
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("True");
            return;
        }

        Stack<char> stack = new Stack<char>();
        bool isValid = true;
        foreach (char c in input)
        {
            if (c == '(' || c == '{' || c == '[' || c == '<')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']' || c == '>')
            {
                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }
                char top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '[') ||
                    (c == '>' && top != '<'))
                {
                    isValid = false;
                    break;
                }
            }
        }
        if (isValid && stack.Count == 0)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}