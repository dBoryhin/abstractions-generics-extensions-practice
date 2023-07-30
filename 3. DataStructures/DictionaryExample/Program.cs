Dictionary<string, int?> cars = new Dictionary<string, int?>
{
    { "BMW", 2019 },
    { "Audi", 2020 },
    { "Mercedes-Benz", 2022 },
    { "Something", null }
};

Console.WriteLine(string.Join(',', cars));

cars.Remove("Audi");
Console.WriteLine(string.Join(',', cars));

Console.WriteLine(cars.ContainsKey("BMW"));
Console.WriteLine(cars.ContainsValue(2022));

cars.Clear();
Console.WriteLine(cars.Count);