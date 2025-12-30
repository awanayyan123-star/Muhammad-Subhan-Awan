using System;
class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle is starting");
    }
}
class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}
class SportsCar : Car
{
    public void Speed()
    {
        Console.WriteLine("Sports car is very fast");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SportsCar sc = new SportsCar();

        sc.Start();  
        sc.Drive();   
        sc.Speed();   

        Console.WriteLine("Inheritance example completed");
        Console.ReadLine();
    }
}
