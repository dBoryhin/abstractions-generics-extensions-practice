// See https://aka.ms/new-console-template for more information

public class Program
{
    private static void Main(string[] args)
    {
        var sentence = "Some default text, like Hello World";

        Console.WriteLine(sentence.GetWordsCount());
    }
}

public static class StringExtension
{
    public static int GetWordsCount(this string text)
    {
        var words = text.Split(' ');
        return words.Length;
    }
}