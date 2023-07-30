Stack<string> cars = new Stack<string>();
cars.Push("BMW");
cars.Push("Audi");
cars.Push("Mercedes-Benz");

Console.WriteLine(string.Join(',', cars));

Console.WriteLine(new string('=', 40));

Console.WriteLine(cars.Pop());

Console.WriteLine(new string('=', 40));
Console.WriteLine(string.Join(',', cars));

Console.WriteLine(new string('=', 40));
Console.WriteLine(cars.Peek());

cars.Clear();
Console.WriteLine(new string('=', 40));
Console.WriteLine("Cars count: {0}", cars.Count);