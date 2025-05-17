using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //проверка скобок
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("YES");
            return;
        }
        Stack<char> stack = new Stack<char>();
        bool isValid = true;
        foreach (char c in input)
        {
            if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }
                stack.Pop();
            }
        }
        if (isValid && stack.Count == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}