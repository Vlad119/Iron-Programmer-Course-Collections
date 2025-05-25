using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //программа определяет, являются ли 2 слова анаграммами
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();
        Console.WriteLine(AreAnagrams(word1, word2) ? "YES" : "NO");
    }

    static bool AreAnagrams(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }
        Dictionary<char, int> frequency = new Dictionary<char, int>();
        foreach (char c in s1)
        {
            if (frequency.ContainsKey(c))
            {
                frequency[c]++;
            }
            else
            {
                frequency.Add(c, 1);
            }
        }
        foreach (char c in s2)
        {
            if (!frequency.ContainsKey(c)) return false;
            frequency[c]--;
        }
        foreach (int count in frequency.Values)
        {
            if (count != 0) return false;
        }
        return true;
    }
}