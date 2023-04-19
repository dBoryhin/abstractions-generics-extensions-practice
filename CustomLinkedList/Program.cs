using System.Collections;

public class Program
{
    private static void Main()
    {
        var myList = new MyLinkedList<int>();

        myList.AddLast(1);
        myList.AddLast(2);

        //var list = new List<int>();

        //var steps = 1_000_000;

        //var sw = new Stopwatch();
        //sw.Start();
        //for (int i = 0; i < steps; i++)
        //{
        //    list.Add(i);
        //}
        //sw.Stop();
        //Console.WriteLine($"list: {sw.ElapsedMilliseconds}. Count: {list.Count}");

        //sw.Restart();
        //for (int i = 0; i < steps; i++)
        //{
        //    myList.AddFirst(i);
        //}
        //sw.Stop();
        //Console.WriteLine($"myList: {sw.ElapsedMilliseconds}. Count: {myList.Count}");

        //myList.AddFirst(1);
        //myList.AddLast(2);
        //myList.AddFirst(3);

        //foreach (var item in myList)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine($"Is 1 in the list? {myList.Contains(1)}");

        //myList.Remove(3);

        //foreach (var item in myList)
        //{
        //    Console.WriteLine(item);
        //}
    }
}

internal class Node<T>
{
    public T? Value { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T value)
    {
        Value = value;
    }
}

public class MyLinkedList<T> : IEnumerable<T>
{
    private Node<T> _head;

    public int Count { get; private set; }

    public void AddFirst(T item)
    {
        var newNode = new Node<T>(item)
        {
            Next = _head,
        };
        _head = newNode;
        Count++;
    }

    public void AddLast(T item)
    {
        var newNode = new Node<T>(item);
        if (_head == null)
        {
            _head = newNode;
            Count++;
            return;
        }
        var current = _head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
        Count++;
    }

    public void Remove(T item)
    {
        if (_head == null)
        {
            return;
        }
        else if (_head.Value!.Equals(item))
        {
            _head = _head.Next!;
            Count--;
            return;
        }

        var current = _head;
        while (current.Next != null)
        {
            if (current.Next.Value!.Equals(item))
            {
                current.Next = current.Next.Next;
                Count--;
                return;
            }
            current = current.Next;
        }
    }

    public bool Contains(T item)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Value!.Equals(item))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = _head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}