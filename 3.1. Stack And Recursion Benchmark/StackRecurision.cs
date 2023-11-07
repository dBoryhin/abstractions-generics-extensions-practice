using BenchmarkDotNet.Attributes;

namespace _3._1._Stack_And_Recursion_Benchmark;

[MemoryDiagnoser]
[RankColumn]
public class StackRecurision
{
    [Params(5, 40)]
    public int Value;

    [Benchmark]
    public void FibonacciStack()
    {
        CalculateFibonacciStack(Value);
    }

    [Benchmark]
    public void FibonacciRecursion()
    {
        CalculateFibonacciRecursion(Value);
    }

    private static ulong CalculateFibonacciRecursion(int n)
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

    private static ulong CalculateFibonacciStack(int n)
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