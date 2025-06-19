using System;
public abstract class Animal
{
    protected string Name;

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public abstract void Eat();
}

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Eating");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the dog's name: ");
        string dogName = Console.ReadLine();

        Dog myDog = new Dog();
        myDog.SetName(dogName);

        Console.WriteLine(myDog.GetName());
        myDog.Eat();
    }
}
