public class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[] { 10, 5, 66, 23, 10 };

        Console.WriteLine(numbers.Ave()); //custom average method
        Console.WriteLine(numbers.Average()); // LINQ method
    }
}

public static class EnumerableExtension
{
    /// <summary>
    /// Custom Average method
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns>Sum of elements divided by elements count</returns>
    public static double Ave(this IEnumerable<int> numbers)
    {
        var result = (double)numbers.Sum() / numbers.Count();
        return result;
    }
}