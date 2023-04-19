var cars = new[]
{
new {Make = "BMW", Model = "5 Series", Year = 2019},
new {Make = "BMW", Model = "4 Series", Year = 2020},
new {Make = "BMW", Model = "M4", Year = 2015},
new {Make = "Audi", Model = "A3", Year = 2012},
new {Make = "Audi", Model = "A6", Year = 2018},
new {Make = "Mercedes-Benz", Model = "E-Class", Year = 2020}
};

var carModels = cars.Select(m => m.Model);
Console.WriteLine(string.Join(',', carModels));

var firstCar = cars.First();
Console.WriteLine(firstCar.ToString());

var lastCar = cars.Last();
Console.WriteLine(lastCar);

var carMakes = cars.Select(m => m.Make).Distinct();
Console.WriteLine(string.Join(',', carMakes));

var taked = cars.Take(2);
Console.WriteLine(string.Join(',', taked));

var skipped = cars.Skip(5);
Console.WriteLine(string.Join(',', skipped));

var maxYear = cars.Max(y => y.Year);
Console.WriteLine($"Max year {maxYear}");

var minYear = cars.Min(y => y.Year);
Console.WriteLine($"Min year {minYear}");

var reverse = cars.Reverse().Select(s => new { s.Model, s.Year });
foreach (var item in reverse)
{
    Console.WriteLine($"{item.Model} {item.Year}");
}

Console.WriteLine("");

var desc = cars.OrderByDescending(s => s.Year);
foreach (var item in desc)
{
    Console.WriteLine($"{item.Make} {item.Model} {item.Year}");
}