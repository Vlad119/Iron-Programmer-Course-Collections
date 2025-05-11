using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<string> books = new List<string>();
        for (int i = 0; i < n; i++)
        {
            books.Add(Console.ReadLine());
        }
        string newBook = Console.ReadLine();
        int position = int.Parse(Console.ReadLine());
        books.Insert(position - 1, newBook);
        string removedBook = Console.ReadLine();
        books.Remove(removedBook);
        string searchBook = Console.ReadLine();
        int index = books.IndexOf(searchBook);
        if (index != -1)
        {
            Console.WriteLine(index + 1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}
