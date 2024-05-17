public class Program
{
    static void Main(string[] args)
    {
        Cat objCat = new Cat();
        objCat.Shout();

        Dog objDog = new Dog();
        objDog.Shout();
    }
}


public abstract class Animal
{
    public abstract string Sound { get; set; }

    public abstract void Shout();
}

public class Cat : Animal
{
    public override string Sound
    {
        get { return "Meow"; }
        set { }
    }

    public override void Shout()
    {
        Console.WriteLine($"Cat Sound {Sound}");
    }
}

public class Dog : Animal
{
    public override string Sound
    {
        get { return "Woof"; }
        set { }
    }

    public override void Shout()
    {
        Console.WriteLine($"Dog Sound {Sound}");
    }
}
