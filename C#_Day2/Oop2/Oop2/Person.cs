namespace Oop2;

// Abstract base class Person
abstract class Person
{
    // Properties common to all persons
    public string Name { get; set; }
    public int Age { get; set; }

    // Abstract method to be implemented by derived classes
    public abstract void ShowYourself();
}

// Derived class Student
class Student : Person
{
    // Additional properties specific to Student
    public int StudentId { get; set; }
    public string Major { get; set; }

    // Implementing abstract method from base class
    public override void ShowYourself()
    {
        Console.WriteLine($"Student: {Name}, Age: {Age}, Student ID: {StudentId}, Major: {Major}");
    }

    // Additional behavior specific to Student
    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}

// Derived class Instructor
class Instructor : Person
{
    // Additional properties specific to Instructor
    public string Title { get; set; }
    public string Subject { get; set; }

    public int YearsOfExperience { get; set; }

    // Implementing abstract method from base class
    public override void ShowYourself()
    {
        Console.WriteLine($"Instructor: {Name}, Age: {Age}, title: {Title}, Subject: {Subject}, WorkExperience: {YearsOfExperience} years");
    }

    // Additional behavior specific to Instructor
    public void Teach()
    {
        Console.WriteLine($"{Name} is teaching {Subject}.");
    }
}
