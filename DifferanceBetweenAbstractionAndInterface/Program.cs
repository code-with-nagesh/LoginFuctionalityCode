using System;

// Abstract class
abstract class Animal
{
    public abstract void MakeSound();
    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

// Interface
interface IFlyable
{
    void Fly();
}

// Derived class implementing both an abstract class and an interface
class Bird : Animal, IFlyable
{
    public override void MakeSound()
    {
        Console.WriteLine("Chirp");
    }

    public void Fly()
    {
        Console.WriteLine("Flying...");
    }
}

class Program
{
    static void Main()
    {
        Bird myBird = new Bird();
        myBird.MakeSound(); // Output: Chirp
        myBird.Sleep();     // Output: Sleeping...
        myBird.Fly();       // Output: Flying...
    }
}
