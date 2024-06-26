// Use /Inheritance/ by leveraging the implementation already created in the Person
// class to save code in Student and Instructor classes
using Oop4;
try
{
    // Creating instances of Student and Instructor
    Student student1 = new Student
    {
        Name = "Chuan",
        Age = 29,
        StudentId = 6785,
        Major = "Computer Science"
    };

    Instructor instructor1 = new Instructor
    {
        Name = "Jian",
        Age = 51,
        Title = "Professor",
        Subject = "Operation system",
        YearsOfExperience = 33
    };

    // Calling methods specific to each type
    student1.Study();
    instructor1.Teach();

    // Displaying details using polymorphism
    Person person1 = new Student
    {
        Name = "Alice",
        Age = 19,
        StudentId = 8765,
        Major = "Computer Science"
    };

    Person person2 = new Instructor
    {
        Name = "Bob",
        Age = 49,
        Title = "Professor",
        Subject = "Programming",
        YearsOfExperience = 30
    };

    person1.ShowYourself();
    person2.ShowYourself();

    // Trying to set invalid values to demonstrate encapsulation
    student1.StudentId = -1; // Throws ArgumentOutOfRangeException
    instructor1.YearsOfExperience = -5; // Throws ArgumentOutOfRangeException
}
catch (Exception ex)
{
    Console.WriteLine($"Exception: {ex.Message}");
}


/*
 * Inheritance allows us to reuse code from a base class in derived classes,
 * reducing redundancy and improving maintainability.
 * We can leverage the existing implementation in the Person class to save code in the Student and Instructor classes.


 */
