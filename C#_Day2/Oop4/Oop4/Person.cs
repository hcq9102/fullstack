namespace Oop4;

// Abstract base class Person
public abstract class Person
{
    // Private fields encapsulated
    private string name;
    private int age;

    // Public properties for encapsulated fields
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Age cannot be negative.");
            }
            age = value;
        }
    }

    // Abstract method to be implemented by derived classes
    public abstract void ShowYourself();
}

// Derived class Student
public class Student : Person
{
    // Private fields encapsulated
    private int studentId;
    private string major;

    // Public properties for encapsulated fields
    public int StudentId
    {
        get { return studentId; }
        set
        {
            // Validate student ID (example)
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Student ID must be greater than zero.");
            }
            studentId = value;
        }
    }

    public string Major
    {
        get { return major; }
        set { major = value; }
    }

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
public class Instructor : Person
{
    // Private fields encapsulated
    private string title;
    private string subject;
    private int yearsOfExperience;

    // Public properties for encapsulated fields
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Subject
    {
        get { return subject; }
        set { subject = value; }
    }

    public int YearsOfExperience
    {
        get { return yearsOfExperience; }
        set
        {
            // Validate years of experience (example)
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Years of experience cannot be negative.");
            }
            yearsOfExperience = value;
        }
    }

    // Implementing abstract method from base class
    public override void ShowYourself()
    {
        Console.WriteLine($"Instructor: {Name}, Age: {Age}, Title: {Title}, Subject: {Subject}, Experience: {YearsOfExperience} years");
    }

    // Additional behavior specific to Instructor
    public void Teach()
    {
        Console.WriteLine($"{Name} is teaching {Subject}.");
    }
}
