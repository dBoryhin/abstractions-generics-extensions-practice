var cars = new[]
{
new {Make = "BMW", Model = "5 Series", Year = 2019},
new {Make = "BMW", Model = "4 Series", Year = 2020},
new {Make = "BMW", Model = "M4", Year = 2015},
new {Make = "Audi", Model = "A3", Year = 2012},
new {Make = "Audi", Model = "A6", Year = 2018},
new {Make = "Mercedes-Benz", Model = "E-Class", Year = 2020}
};

var deferredQuery = cars.Where(s => s.Make == "Audi");
var immediateQuery = cars.Where(s => s.Make == "Audi").ToList();

#region Differences

//var immediateQueryCount = immediateQuery.Count;
//var deferredQueryCount = deferredQuery.Count();

//var car = deferredQuery[1];
//var car1 = immediateQuery[1];

#endregion Differences

Console.WriteLine("Deferred query result");
foreach (var item in deferredQuery)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine("Immediate query result");
foreach (var item in immediateQuery)
{
    Console.WriteLine(item);
}

//I've realized - I've made a mistake. [3] element should not be Audi A3. but Audi A4 2023
cars[3] = new { Make = "Audi", Model = "A4", Year = 2023 };

Console.WriteLine(new string('=', 20));
Console.WriteLine("Deferred query result");
foreach (var item in deferredQuery)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine("Immediate query result");
foreach (var item in immediateQuery)
{
    Console.WriteLine(item);
}

Console.ReadLine();