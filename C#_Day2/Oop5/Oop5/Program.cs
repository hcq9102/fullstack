/*
 * Polymorphism in object-oriented programming allows methods to be defined in a base class
 * and overridden in derived classes to provide specific behavior.
 *
 * This can be achieved using virtual methods in the base class and overriding them in derived classes.
 */
// Creating instances of Student and Instructor

using Oop5;

Student student1 = new Student
{
    Name = "Qiu",
    Age = 23,
    StudentId = 5665,
    Major = "Computer Science"
};

Instructor instructor1 = new Instructor
{
    Name = "Jaden",
    Age = 49,
    Title = "Professor",
    Subject = "C++",
    YearOfExperience = 30,
    BaseSalary = 70000
};

// Displaying details and calculating salary using polymorphism
Person[] people = { student1, instructor1 };

foreach (var person in people)
{
    person.ShowYourself();
    Console.WriteLine($"Salary: {person.CalculateSalary():C}");
    Console.WriteLine();
}
