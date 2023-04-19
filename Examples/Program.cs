namespace Examples;

public class Program
{
    private static void Main(string[] args)
    {
        var class1 = new MyTestClass()
        {
            Value = 10
        };
        var class2 = new MyTestClass()
        {
            Value = 20
        };

        Print($"10 + 20 = ", 10 + 20);
        Print($"10 - 20 = ", 10 - 20);
        Console.WriteLine("Once again but with MyTestClass values:");
        Print($"{class1.Value} + {class2.Value} = ", class1 + class2);
        Print($"{class1.Value} - {class2.Value} = ", class1 - class2);
        Print($"{class1.Value} > {class2.Value} = ?", class1 > class2);
        Print($"{class1.Value} < {class2.Value} = ?", class1 < class2);

        Console.ReadLine();
    }

    public static void Print<T>(string message, T result)
    {
        Console.Write(message);
        Console.ReadLine();
        Console.WriteLine(result);

        Console.WriteLine();
    }
}