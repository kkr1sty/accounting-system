using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

List<string> products = new List<string>();
List<double> prices = new List<double>();

//Устанавливаем список продуктов
Console.Write("Введите продукты через запятую: ");
    string input = Console.ReadLine();


    var list = input
    .Split(',')
    .Select(s => s.Trim())
    .Where(s => !string.IsNullOrEmpty(s))
    .ToList();

products.AddRange(list);

//Вывод всего списка
Console.Write("Список продуктов: ");
foreach (var n in products)
{
    
    Console.Write($" {n}");
}


//Устанавливаем цену к продуктам
for (int i = 0; i < products.Count; i++)
{
    Console.Write($"\nВведите цену для {products[i]}: ");
    double price = double.Parse(Console.ReadLine());

    prices.Add(price);
}

//Вывод информации
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{products[i]} стоит {prices[i]} руб.  ID={i}");
}


//Поиск по id
while (true)
{
    Console.WriteLine("ID товара который хотите найти или 1111 для выхода:");
    int id = int.Parse(Console.ReadLine());
    if ( id== 1111) break;
    if (id > products.Count)
    {
        Console.WriteLine($"Ошибка товара с ID {id} не существует");
        continue;
    }
    Console.WriteLine($"Найден товар с ID {id}.   Название:{products[id]}   Цена {prices[id]}");
    
}