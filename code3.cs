using System;

// Parent Class
class Person
{
    public string Name;
    public int Age;using System;

// Parent Class
class Person
{
    public string Name;
    public int Age;

    public void DisplayPerson()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

// Child Class
class Student : Person
{
    // Encapsulation
    private int mark;

    public void SetMark(int m)
    {
        if (m >= 0 && m <= 100)
        {
            mark = m;
        }
        else
        {
            Console.WriteLine("Invalid Mark");
        }
    }

    public int GetMark()
    {
        return mark;
    }

    public void DisplayStudent()
    {
        Console.WriteLine("Student Details");
        Console.WriteLine("----------------");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Mark: " + mark);
    }
}

// Main Class
class Program
{
    static void Main()
    {
        // Object creation
        Student student = new Student();

        // Inherited properties
        student.Name = "Gayathri";
        student.Age = 21;

        // Encapsulated data
        student.SetMark(85);

        // Display
        student.DisplayStudent();

        Console.WriteLine("Mark using GetMark(): " + student.GetMark());
    }
}


