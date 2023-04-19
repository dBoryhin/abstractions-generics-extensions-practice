Queue<string> cars = new Queue<string>();

cars.Enqueue("BMW");
cars.Enqueue("Audi");
cars.Enqueue("Mercedes-Benz");
foreach (var car in cars)
{
    Console.WriteLine(car);
}

Console.WriteLine(new string('=', 40));

cars.Dequeue();
foreach (var car in cars)
{
    Console.WriteLine(car);
}

Console.WriteLine(new string('=', 40));

var item = cars.Peek();
Console.WriteLine(item);