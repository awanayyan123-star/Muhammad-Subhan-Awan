

using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dog d1 = new Dog();
        d1.Eat();   // Parent class method
        d1.Bark();  // Child class method

        Console.WriteLine("Program finished");
        Console.ReadLine();
    }
}
