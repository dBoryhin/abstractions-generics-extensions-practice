public class Program
{
    private static void Main(string[] args)
    {
        var calculation = new Calculation();
        Console.WriteLine(calculation.CalcSum(1, 2));
        Console.WriteLine(calculation.CalcSum(1.1, 0.9));
    }
}

public interface IIntCalc
{
    int Sum { get; }

    int CalcSum(int x, int y);
}

public interface IDoubleCalc
{
    double CalcSum(double x, double y);
}

public class Calculation : IIntCalc, IDoubleCalc
{
    public int Sum { get; }

    public int CalcSum(int x, int y)
        => x + y;

    public double CalcSum(double x, double y)
        => x + y;
}