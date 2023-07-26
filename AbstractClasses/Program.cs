internal class Program
{
    private static void Main(string[] args)
    {
        Human human = new Human();
        human.Move();

        DomesticCat cat = new DomesticCat();
        cat.Move();
    }
}

public abstract class Animal
{
    public string Name { get; set; }

    public abstract void Move();
}

public abstract class Mammal : Animal
{
}

public class Human : Mammal
{
    public Human() => Name = "Human";

    public override void Move()
    {
        Console.WriteLine("On two legs");
    }
}

public class DomesticCat : Mammal
{
    public DomesticCat() => Name = "Domestic cat";

    public override void Move()
    {
        Console.WriteLine("On four legs");
    }
}