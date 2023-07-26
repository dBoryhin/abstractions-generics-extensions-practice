namespace Indexers;

public class Program
{
    private static void Main(string[] args)
    {
        var gameField = new GameField();
        Console.WriteLine(gameField[10, 5]?.Name ?? "-");
        Console.WriteLine(gameField[10, 15]?.Name ?? "-");
    }
}

public struct Point
{
    public int X, Y;
}

public class Ship
{
    public string Name { get; set; }
}

internal class GameField
{
    protected Dictionary<Point, Ship> Field = new Dictionary<Point, Ship>();

    public GameField()
    {
        Field.Add(new Point { X = 10, Y = 5 }, new Ship { Name = "Titanic" });
        Field.Add(new Point { X = 3, Y = 7 }, new Ship { Name = "Star" });
    }

    public Ship? this[int x, int y]
    {
        get
        {
            Point point = new Point { X = x, Y = y };
            return Field.ContainsKey(point) ? Field[point] : null;
        }
    }
}