﻿string command = Console.ReadLine();

Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

while (command != "Revision")
{
    string[] commandParts = command.Split(", ");
    string shop = commandParts[0];
    string product = commandParts[1];
    double price = double.Parse(commandParts[2]);

    if (!shops.ContainsKey(shop))
    {
        shops.Add(shop, new Dictionary<string, double>());
    }

    shops[shop].Add(product, price);

    command = Console.ReadLine();
}

foreach (var entry in shops.OrderBy(s => s.Key))
{
    Console.WriteLine(entry.Key + "->");

    foreach (var product in entry.Value)
    {
        //key: име на продукта
        // value: цена на продукта
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}