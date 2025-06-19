using System;
using System.Collections.Generic;

public class MainClass
{
    public static void Main()
    {
        var word = Console.ReadLine();
        var dict1 = new Dictionary<char, int>();
        for (int i = 0; i < word.Length; i++)
        {
            if (dict1.ContainsKey(word[i]))
            {
                dict1[word[i]]++;
            }
            else
            {
                dict1.Add(word[i], 1);
            }
        }
        int n = Convert.ToInt32(Console.ReadLine());
        var dict2 = new Dictionary<int, char>();
        for (int i = 0; i < n; i++)
        {
            var str = Console.ReadLine().Split(new string[] { ": " }, StringSplitOptions.None);
            dict2[Convert.ToInt32(str[1])] = Convert.ToChar(str[0]);
        }
        foreach (var c in word)
        {
            Console.Write(dict2[dict1[c]]);
        }
    }
}