using System.Collections;

namespace Collections;

public class Program
{
    private static void Main(string[] args)
    {
        Week week = new Week();
        foreach (var day in week)
        {
            Console.WriteLine(day);
        }
    }
}

public class Week : IEnumerable
{
    private readonly string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    public IEnumerator GetEnumerator() => new WeekEnumerator(days);
}

public class WeekEnumerator : IEnumerator
{
    private string[] days;
    private int position = -1;

    public WeekEnumerator(string[] days)
    {
        this.days = days;
    }

    public object Current => days[position];
    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        if (position < days.Length - 1)
        {
            position++;
            return true;
        }
        return false;
    }

    public void Reset() => position = -1;

    public void Dispose()
    { }
}