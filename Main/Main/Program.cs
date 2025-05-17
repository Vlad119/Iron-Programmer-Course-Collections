using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()//проверка скобок в программе
    {
        // Считываем строки до пустой строки
        List<string> lines = new List<string>();
        string line;
        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            lines.Add(line);
        }
        // Стеки для хранения открывающих скобок и номеров строк
        Stack<char> stack = new Stack<char>();
        Stack<int> lineStack = new Stack<int>();
        // Проходим по каждой строке
        for (int i = 0; i < lines.Count; i++)
        {
            string currentLine = lines[i];
            foreach (char c in currentLine)
            {
                // Если открывающая скобка, добавляем её в стек с номером строки
                if ("([{<".Contains(c))
                {
                    stack.Push(c);
                    lineStack.Push(i + 1); // Сохраняем номер строки
                }
                // Если закрывающая скобка
                else if (")]}>".Contains(c))
                {
                    if (stack.Count == 0)
                    {
                        // Несоответствие: закрывающая скобка без открывающей
                        Console.WriteLine(i + 1);
                        return;
                    }
                    // Проверяем соответствие открывающей и закрывающей скобок
                    char top = stack.Pop();
                    int lineNumber = lineStack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{') ||
                        (c == '>' && top != '<'))
                    {
                        // Несоответствие скобок
                        Console.WriteLine(i + 1);
                        return;
                    }
                }
            }
        }
        // Если в стеке остались незакрытые скобки
        if (stack.Count > 0)
        {
            Console.WriteLine(lines.Count); // Возвращаем номер последней строки
            return;
        }
        // Если все скобки расположены правильно
        Console.WriteLine(-1);
    }
}