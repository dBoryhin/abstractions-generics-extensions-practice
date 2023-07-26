internal class Program
{
    private class ExampleClass
    { }

    private static void Main(string[] args)
    {
        var list1 = new GenericList<int>();
        list1.Add(1);

        var list2 = new GenericList<string>();
        list2.Add("text");

        var list3 = new GenericList<ExampleClass>();
        list3.Add(new ExampleClass());
    }
}

public class GenericList<T>
{
    public void Add(T item)
    {
        Console.WriteLine($"Item: '{item}' of type '{typeof(T).Name}' has been added to the list.");
    }
}