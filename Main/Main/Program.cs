using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string expression = Console.ReadLine();
        Queue<char> reversePolishNotation = ProcessReversePolishNotation(expression);
        // Выводим ОПЗ
        PrintReversePolishNotation(reversePolishNotation);
        // Вычисляем результат
        double result = EvaluateReversePolishNotation(new Queue<char>(reversePolishNotation));
        Console.WriteLine(result);
    }

    static Queue<char> ProcessReversePolishNotation(string expression)
    {
        Queue<char> reversePolishNotation = new Queue<char>();
        var priority = new Dictionary<char, int>()
        {
            ['+'] = 1,
            ['-'] = 1,
            ['*'] = 2,
            ['/'] = 2,
            ['('] = 0
        };
        Stack<char> operators = new Stack<char>();

        for (int i = 0; i < expression.Length; i++)
        {
            char current = expression[i];
            if (Char.IsDigit(current))
            {
                reversePolishNotation.Enqueue(current);
            }
            else if (current == '(')
            {
                operators.Push(current);
            }
            else if (current == ')')
            {
                while (operators.Count > 0 && operators.Peek() != '(')
                {
                    reversePolishNotation.Enqueue(operators.Pop());
                }
                if (operators.Count > 0 && operators.Peek() == '(')
                {
                    operators.Pop();
                }
            }
            else if (IsOperator(current))
            {
                while (operators.Count > 0 && priority[current] <= priority[operators.Peek()])
                {
                    reversePolishNotation.Enqueue(operators.Pop());
                }
                operators.Push(current);
            }
        }

        while (operators.Count > 0)
        {
            reversePolishNotation.Enqueue(operators.Pop());
        }
        return reversePolishNotation;
    }

    static bool IsOperator(char c)
    {
        return c == '+' || c == '-' || c == '*' || c == '/';
    }

    static void PrintReversePolishNotation(Queue<char> reversePolishNotation)
    {
        foreach (char c in reversePolishNotation)
        {
            Console.Write(c);
        }
        Console.WriteLine();
    }

    static int EvaluateReversePolishNotation(Queue<char> reversePolishNotation)
    {
        Stack<int> stack = new Stack<int>();
        while (reversePolishNotation.Count > 0)
        {
            char current = reversePolishNotation.Dequeue();

            if (Char.IsDigit(current))
            {
                stack.Push(current - '0'); // Преобразуем символ в число
            }
            else if (IsOperator(current))
            {
                int b = stack.Pop(); // Второй операнд
                int a = stack.Pop(); // Первый операнд
                switch (current)
                {
                    case '+':
                        stack.Push(a + b);
                        break;
                    case '-':
                        stack.Push(a - b);
                        break;
                    case '*':
                        stack.Push(a * b);
                        break;
                    case '/':
                        stack.Push(a / b);
                        break;
                }
            }
        }
        return stack.Pop(); // Результат вычислений
    }
}