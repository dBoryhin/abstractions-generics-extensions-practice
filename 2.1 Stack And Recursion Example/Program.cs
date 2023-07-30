using System.Diagnostics;

namespace _2._1_Stack_And_Recursion_Example;

internal class Program
{
    private static void Main(string[] args)
    {
        //https://www.omnicalculator.com/math/fibonacci
        Console.WriteLine("Enter the number 'n' to calculate the nth Fibonacci number:");

        //1 1 2 3 5 8 13 21 34 ...

        var values = new int[] { 5, 10, 20, 40, 45,/* 80, 90, */};

        foreach (var value in values)
        {
            // n = 40 : 102334155
            // n = 90 : 2880067194370816120
            var recursionStopWatch = new Stopwatch();
            recursionStopWatch.Start();
            var resultRecursion = CalculateFibonacciRecursion(value);
            recursionStopWatch.Stop();
            Console.WriteLine($"The {value}-th Fibonacci number is: {resultRecursion} in {recursionStopWatch.ElapsedMilliseconds} ms. RECURSION");

            var stackStopWatch = new Stopwatch();
            stackStopWatch.Start();
            var resultStack = CalculateFibonacciStack(value);
            stackStopWatch.Stop();
            Console.WriteLine($"The {value}-th Fibonacci number is: {resultStack} in {stackStopWatch.ElapsedMilliseconds} ms. STACK");

            Console.WriteLine(new string('=', 40));
        }
    }

    public static ulong CalculateFibonacciRecursion(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("n must be a positive long.");
        }
        else if (n == 1 || n == 2)
        {
            return 1;
        }
        else
        {
            return CalculateFibonacciRecursion(n - 1) + CalculateFibonacciRecursion(n - 2);
        }
    }

    public static ulong CalculateFibonacciStack(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("n must be a positive long.");
        }
        else if (n == 1 || n == 2)
        {
            return 1;
        }
        else
        {
            Stack<ulong> fibStack = new Stack<ulong>();
            fibStack.Push(1);
            fibStack.Push(1);

            for (int i = 3; i <= n; i++)
            {
                ulong prev = fibStack.Pop();
                ulong prevPrev = fibStack.Peek();
                fibStack.Push(prev);
                fibStack.Push(prev + prevPrev);
            }

            return fibStack.Peek();
        }
    }
}