using System;

class Program
{
    // Method - Total Marks
    static int TotalMarks(int[] marks)
    {
        int total = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            total = total + marks[i];
        }

        return total;
    }

    // Method - Vote Eligibility
    static void CheckAge(int age)
    {
        if (age >= 18)
        {
            Console.WriteLine("Eligible to Vote");
        }
        else
        {
            Console.WriteLine("Not Eligible to Vote");
        }
    }

    static void Main()
    {
        // String Input
        Console.Write("Enter Your Name: ");
        string name = Console.ReadLine();

        // Integer Input
        Console.Write("Enter Your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Array
        int[] marks = new int[3];

        Console.WriteLine("Enter 3 Marks:");

        for (int i = 0; i < marks.Length; i++)
        {
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Output
        Console.WriteLine("\n----- Student Details -----");
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age  : " + age);

        // Method Call
        CheckAge(age);

        Console.WriteLine("Marks:");

        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine(marks[i]);
        }

        int total = TotalMarks(marks);

        Console.WriteLine("Total Marks = " + total);

        // Conditional
        if (total >= 150)
        {
            Console.WriteLine("Result : Pass");
        }
        else
        {
            Console.WriteLine("Result : Fail");
        }
    }
}
