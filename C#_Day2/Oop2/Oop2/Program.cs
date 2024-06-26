
using Oop2;

// Method to display details using abstraction (base class reference)
static void ShowPersonDetails(Person person)
{
    person.ShowYourself(); // Calls the overridden method based on actual object type
}

// Creating instances of Student and Instructor
Student student1 = new Student
{
    Name = "Alice",
    Age = 19,
    StudentId = 8765,
    Major = "Computer Science"
};

Instructor instructor1 = new Instructor
{
    Name = "Bob",
    Age = 49,
    Title = "Professor",
    Subject = "Programming",
    YearsOfExperience = 30
};

// Calling methods specific to each type
student1.Study();
instructor1.Teach();

// Displaying details using polymorphism
ShowPersonDetails(student1);
ShowPersonDetails(instructor1);

