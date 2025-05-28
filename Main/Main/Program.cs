using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> postfix = ToPostfix(input);
        Console.WriteLine(string.Join(" ", postfix) + " ");
        double result = EvaluatePostfix(postfix);
        Console.WriteLine(result + " ");
    }

    static List<string> ToPostfix(string expression)
    {
        var output = new List<string>();
        var operators = new Stack<string>();
        var priority = new Dictionary<string, int>
        {
            ["+"] = 1,
            ["-"] = 1,
            ["*"] = 2,
            ["/"] = 2,
            ["^"] = 3,
            ["("] = 0
        };

        string[] tokens = expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var token in tokens)
        {
            if (IsNumber(token))
            {
                output.Add(token);
            }
            else if (token == "(")
            {
                operators.Push(token);
            }
            else if (token == ")")
            {
                while (operators.Peek() != "(")
                {
                    output.Add(operators.Pop());
                }
                operators.Pop();
            }
            else if (IsOperator(token))
            {
                while (operators.Count > 0 && priority[operators.Peek()] >= priority[token])
                {
                    output.Add(operators.Pop());
                }
                operators.Push(token);
            }
        }

        while (operators.Count > 0)
        {
            output.Add(operators.Pop());
        }

        return output;
    }

    static double EvaluatePostfix(List<string> postfix)
    {
        var stack = new Stack<double>();

        foreach (var token in postfix)
        {
            if (IsNumber(token))
            {
                stack.Push(double.Parse(token));
            }
            else if (IsOperator(token))
            {
                double b = stack.Pop();
                double a = stack.Pop();

                switch (token)
                {
                    case "+":
                        stack.Push(a + b);
                        break;
                    case "-":
                        stack.Push(a - b);
                        break;
                    case "*":
                        stack.Push(a * b);
                        break;
                    case "/":
                        stack.Push(a / b);
                        break;
                    case "^":
                        stack.Push(Math.Pow(a, b));
                        break;
                }
            }
        }

        return stack.Pop();
    }

    static bool IsNumber(string token)
    {
        return double.TryParse(token, out _);
    }

    static bool IsOperator(string token)
    {
        return token == "+" || token == "-" || token == "*" || token == "/" || token == "^";
    }
}