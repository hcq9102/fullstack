namespace Oop5;

// Abstract base class Person

public abstract class Person
{
    // properties
    public string Name { get; set; }
    public int Age { get; set; }

    // virtual method
    public virtual double CalculateSalary()
    {
        return 0.0;
    }
    // abstract method
    public abstract void ShowYourself();
}

// drived class student
public class Student : Person
{
    // Additional properties specific to student
    public int StudentId { get; set; }
    public string Major { get; set; }

    // implementing abstarct method from base class
    public override void ShowYourself()
    {
        Console.WriteLine($"Student: {Name}, Age: {Age}, Student ID: {StudentId}, Major: {Major}");
    }

    public override double CalculateSalary()
    {
        return 0.0; // no salary
    }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying");
    }
}

// Derived class instructor

public class Instructor : Person
{
    public string Title { get; set; }
    public string Subject { get; set; }

    public int YearOfExperience { get; set; }
    public double BaseSalary { get; set; }

    // virtual method imp
    public override double CalculateSalary()
    {
        return BaseSalary + YearOfExperience * 1200;
    }
    // abstract method
    public override void ShowYourself()
    {
        Console.WriteLine($"Instructor: {Name}, Age: {Age}, Title: {Title}, Subject: {Subject}, Experience: {YearOfExperience} years");
    }

    // Additional behavior specific to Instructor
    public void Teach()
    {
        Console.WriteLine($"{Name} is teaching {Subject}.");
    }

}


