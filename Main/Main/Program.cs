using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    // приложение разворачивает строку и удаляет повторы
    {
        string[] split = Console.ReadLine().Split(' ');
        Stack<string> stack = new Stack<string>();
        stack.Push(split[0]);
        foreach (string s in split)
        {
            if(!s.Contains(stack.Peek()))
            stack.Push(s);
        }
        Console.WriteLine(string.Join(" ", stack));
    }
}
