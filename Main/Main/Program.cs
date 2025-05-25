using System.Collections.Generic;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        // Словарь 1
        Dictionary<int, string> dictionary1 = new Dictionary<int, string>()
        {
            [1] = "Val1",
            [3] = "Val3",
            [5] = "Val5"
        };
        // Словарь 2
        Dictionary<int, string> dictionary2 = new Dictionary<int, string>()
        {
            [1] = "Val11",
            [2] = "Val2",
            [4] = "Val4"
        };
        // Объединение словарей
        Dictionary<int, string> combinedDictionary = CombineDictionaries(dictionary1, dictionary2);
        // Вывод результата
        foreach (var item in combinedDictionary)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }

    static Dictionary<int, string> CombineDictionaries(Dictionary<int, string> dict1, Dictionary<int, string> dict2)
    {
        Dictionary<int, string> result = new Dictionary<int, string>(dict1);
        foreach (var item in dict2)
        { 
            if (!result.ContainsKey(item.Key))
            {
                result.Add(item.Key, item.Value);
            }
        }
        return result;
    }
}
