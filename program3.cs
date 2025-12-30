using System;
class Person
{
    public string name;
    public int age;

    public void ShowPerson()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}
class Student : Person
{
    public int rollNo;

    public void ShowStudent()
    {
        Console.WriteLine("Roll Number: " + rollNo);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();

        s1.name = "Ali";
        s1.age = 20;
        s1.rollNo = 101;

        s1.ShowPerson();
        s1.ShowStudent();

        Console.ReadLine();
    }
}
