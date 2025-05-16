using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Считываем входную строку и разбиваем её на список слов
        string input = Console.ReadLine();
        List<string> list = new List<string>(input.Split(' '));

        // Создаем список для хранения всех подсписков
        List<List<string>> result = new List<List<string>>();

        // Добавляем пустой подсписок только один раз
        result.Add(new List<string>());

        // Генерируем подсписки по возрастанию их длины
        for (int length = 1; length <= list.Count; length++) // length — длина подсписка
        {
            for (int i = 0; i <= list.Count - length; i++) // i — начальный индекс
            {
                List<string> sublist = list.GetRange(i, length);
                result.Add(sublist);
            }
        }

        // Форматируем вывод
        Console.Write("[");
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write("[");
            for (int j = 0; j < result[i].Count; j++)
            {
                Console.Write($"'{result[i][j]}'");
                if (j < result[i].Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
            if (i < result.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}