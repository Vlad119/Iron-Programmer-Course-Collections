using System;
using System.Collections.Generic;

class Program
{
    static void Main()
        //задача про авторизацию по пути
    {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> allowedPaths = new HashSet<string>();
        for (int i = 0; i < n; i++)
        {
            allowedPaths.Add(Console.ReadLine());
        }
        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            string request = Console.ReadLine();
            bool isAllowed = false;
            for (int j = 1; j <= request.Length; j++)
            {
                if (request[j - 1] == '/' || j == request.Length)
                {
                    string prefix = request.Substring(0, j == request.Length ? j : j - 1);
                    if (allowedPaths.Contains(prefix))
                    {
                        isAllowed = true;
                        break;
                    }
                }
            }
            Console.WriteLine(isAllowed ? "YES" : "NO");
        }
    }
}