using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string expression = Console.ReadLine();
        Queue<char> reversePolishNotation;
        reversePolishNotation = ProcessReversePolishNotation(expression);
        PrintReversePolishNotation(reversePolishNotation);
    }

    static Queue<char> ProcessReversePolishNotation(string expression)
    {
        Queue<char> reversePolishNotation = new Queue<char>(); //очередь для добавления элементов выражения
        var priority = new Dictionary<char, int>() // словарь для хранения значений приоритетов
        {
            ['+'] = 1,
            ['-'] = 1,
            ['*'] = 2,
            ['/'] = 2
        };
        Stack<char> operators = new Stack<char>(); // стек для временного хранения операторов

        for (int i = 0; i < expression.Length; i++)
        {
            char current = expression[i]; // текущий символ
            if (Char.IsDigit(current)) // если символ число, добавляем его в очередь
            {
                reversePolishNotation.Enqueue(current);
            }
            else if (IsOperator(current)) // проверяем является ли символ оператором
            {
                while (operators.Count > 0 && priority[current] <= priority[operators.Peek()]) // пока стек не пустой и на его вершине оператор с приоритетом выше или равен текущему, то добавляем оператор из стека в очередь
                {
                    reversePolishNotation.Enqueue(operators.Pop());
                }
                operators.Push(current); // добавляем текущий оператор в стек операторов
            }
        }

        while (operators.Count > 0) // если после перебора всех элементов строки в стеке остались операторы, то переносим их в очередь
        {
            reversePolishNotation.Enqueue(operators.Pop());
        }

        return reversePolishNotation; // возвращаем сформированную очередь
    }

    static bool IsOperator(char c) // функция определяющая является ли символ оператором
    {
        return c == '+' || c == '-' || c == '*' || c == '/';
    }

    static void PrintReversePolishNotation(Queue<char> reversePolishNotation) // функция для вывода на консоль элементов очереди
    {
        foreach (char c in reversePolishNotation)
        {
            Console.Write(c);
        }
    }
}