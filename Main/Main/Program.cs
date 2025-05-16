using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        string s = string.Empty;
        Stack<string> stack = new Stack<string>();
        while (true)
        {
            s = Console.ReadLine();
            if (s != "Конец списка") stack.Push(s);
            else break;
        }
        while (stack.Count > 0)
        {
            if (stack.Peek() == "+")
            {
                if (stack.Count != 0) stack.Pop();
                if (stack.Count != 0) stack.Pop();
            }
            else Console.WriteLine(stack.Pop());
        }
    }
}
