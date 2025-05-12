using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string result = string.Join(" ", GetNumbers(input));
        Console.WriteLine(result);
    }

    static List<int> GetNumbers(string s)//из текста нужно выбрать только цифры и вывести на экран
    {
        List<int> result = new List<int>();
        string currentNumber = string.Empty; 
        foreach (char c in s)
        {
            if (char.IsDigit(c)) 
            {
                currentNumber += c;
            }
            else
            {
                if (!string.IsNullOrEmpty(currentNumber)) 
                {
                    result.Add(int.Parse(currentNumber));
                    currentNumber = string.Empty;
                }
            }
        }
        if (!string.IsNullOrEmpty(currentNumber))
        {
            result.Add(int.Parse(currentNumber));
        }
        return result;
    }
}
