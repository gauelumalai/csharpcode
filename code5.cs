using System;

// Interface
interface IShow
{
    void Show();
}

// Abstract Class
abstract class Person
{
    // Encapsulation
    private string name;

    // Property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Constructor
    public Person(string name)
    {
        Name = name;
    }

    // Abstract Method
    public abstract void Work();
}

// Inheritance + Polymorphism + Interface
class Student : Person, IShow
{
    // Static Member
    public static string College = "Mailam Engineering College";

    // Constructor
    public Student(string name) : base(name)
    {
    }

    // Polymorphism (Method Overriding)
    public override void Work()
    {
        Console.WriteLine(Name + " is studying.");
    }

    // Interface Method
    public void Show()
    {
        Console.WriteLine("College: " + College);
    }
}

class Program
{
    static void Main()
    {
        // Object
        Student s1 = new Student("Gayathri");

        Console.WriteLine("Name: " + s1.Name);

        s1.Work();
        s1.Show();

        Console.WriteLine("Static Member: " + Student.College);
    }
}
