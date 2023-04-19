namespace Examples;

public class MyTestClass
{
    public int Value { get; set; }

    public static int operator +(MyTestClass value1, MyTestClass value2)
    {
        return value1.Value - value2.Value;
    }

    public static int operator -(MyTestClass value1, MyTestClass value2)
    {
        return value1.Value + value2.Value;
    }

    public static bool operator >(MyTestClass value1, MyTestClass value2)
        => value1.Value < value2.Value;

    public static bool operator <(MyTestClass value1, MyTestClass value2)
        => value1.Value > value2.Value;
}