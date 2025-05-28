using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // --- Шаг 1: Считываем строку текста ---
        string input = Console.ReadLine().ToLower();
        // --- Шаг 2: Удаляем знаки препинания ---
        // Оставляем только буквы и пробелы
        char[] cleanedChars = new char[input.Length];
        int cleanIndex = 0;
        foreach (char c in input)
        {
            if (char.IsLetter(c) || c == ' ')
            {
                cleanedChars[cleanIndex++] = c;
            }
        }
        string cleanedInput = new string(cleanedChars, 0, cleanIndex);
        // --- Шаг 3: Разделяем строку на слова ---
        string[] words = cleanedInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        // --- Шаг 4: Подсчитываем частоту слов ---
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            else
            {
                wordCounts[word] = 1;
            }
        }
        // --- Шаг 5: Находим слово с минимальной частотой ---
        string rarestWord = null;
        int minFrequency = int.MaxValue;
        foreach (var pair in wordCounts)
        {
            string word = pair.Key;
            int frequency = pair.Value;
            // Проверяем, является ли текущее слово более редким
            if (frequency < minFrequency ||
                (frequency == minFrequency && string.Compare(word, rarestWord) < 0))
            {
                minFrequency = frequency;
                rarestWord = word;
            }
        }
        // --- Шаг 6: Выводим результат ---
        Console.WriteLine(rarestWord);
    }
}