using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    //удаление повторяющихся друг за другом символов и вывод нормальной строки
    {
        string[] split = Console.ReadLine().Split();
        string str = string.Join(" ", split);
        Stack<char> stack = new Stack<char>();
        stack.Push(str[0]);
        foreach (char c in str)
        {
            if (c != stack.Peek()) stack.Push(c);
        }
        stack = new Stack<char>(stack);//переворачиваем стек
        Console.WriteLine(string.Join("", stack));
    }
}
