using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // --- Шаг 1: Считываем данные о своих товарах ---
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, int> myProducts = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {
            string[] productData = Console.ReadLine().Split(new string[] { ": ", " руб" }, StringSplitOptions.RemoveEmptyEntries);
            string productName = productData[0].Trim();
            int price = int.Parse(productData[1].Trim());
            myProducts[productName] = price;
        }
        // --- Шаг 2: Считываем и парсим HTML-данные конкурентов ---
        Dictionary<string, int> competitorProducts = new Dictionary<string, int>();
        string htmlLine;
        while (!string.IsNullOrEmpty(htmlLine = Console.ReadLine()))
        {
            // Проверяем, что строка содержит теги <li> и </li>
            if (htmlLine.Contains("<li>") && htmlLine.Contains("</li>"))
            {
                // Удаляем теги <li> и </li>
                int startIndex = htmlLine.IndexOf("<li>") + 4; // Длина "<li>" = 4
                int endIndex = htmlLine.IndexOf("</li>");
                string productInfo = htmlLine.Substring(startIndex, endIndex - startIndex).Trim();
                // Разделяем название товара и цену
                string[] productData = productInfo.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                if (productData.Length == 2)
                {
                    string productName = productData[0].Trim();
                    int price = int.Parse(productData[1].Replace(" руб", "").Trim());
                    competitorProducts[productName] = price;
                }
            }
        }
        // --- Шаг 3: Вычисляем разницу в ценах ---
        List<string> results = new List<string>();
        int totalDifference = 0;
        foreach (var myProduct in myProducts)
        {
            string productName = myProduct.Key;
            int myPrice = myProduct.Value;
            int difference = 0;
            if (competitorProducts.ContainsKey(productName))
            {
                int competitorPrice = competitorProducts[productName];
                difference = competitorPrice - myPrice;
            }
            totalDifference += difference;
            results.Add($"{productName}: {difference} руб");
        }
        // --- Шаг 4: Выводим результаты ---
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
        Console.WriteLine($"Итого: {totalDifference} руб");
    }
}