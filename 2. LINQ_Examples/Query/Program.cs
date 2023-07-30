int[] numbers = new int[20];

Random random = new();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 101);
}

Console.WriteLine(string.Join(',', numbers));

IEnumerable<int> resultQuery = from number in numbers
                               where number > 50
                               orderby number
                               select number;

Console.WriteLine(string.Join(',', resultQuery));

#region Extension

IEnumerable<int> resultExtension = numbers.Where(n => n > 50).OrderBy(number => number);
Console.WriteLine(string.Join(',', resultExtension));

#endregion Extension