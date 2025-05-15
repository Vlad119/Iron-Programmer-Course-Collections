using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {

    }

    static List<List<string>> Chunked(List<string> list, int n) // создаёт чанки из строки
    {
        List<List<string>> result = new List<List<string>>();
        for (int i = 0; i < list.Count; i += n)
        {
            List<string> chunk = list.GetRange(i, Math.Min(n, list.Count - i));
            result.Add(chunk);
        }
        return result;
    }
}
