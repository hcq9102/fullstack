/*
 * Use /Encapsulation/ to keep many details private in each class.
 */

//Student and Instructor classes to encapsulate their internal details by making fields private and providing public properties for access.
//This ensures that the internal state of each class is protected and accessed only through controlled interfaces.
using Oop3;

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
Person person1 = new Student
{
    Name = "Leo",
    Age = 20,
    StudentId = 12534,
    Major = "Computer Science"
};

Person person2 = new Instructor
{
    Name = "Smith",
    Age = 50,
    Title = "Professor",
    Subject = "Algorithms",
    YearsOfExperience = 32
};

person1.ShowYourself();
person2.ShowYourself();
/*
 *Encapsulation in Student and Instructor Classes:

   Private fields (studentId, major for Student; title, subject, yearsOfExperience for Instructor) are encapsulated.
   Public properties (StudentId, Major for Student; Title, Subject, YearsOfExperience for Instructor) provide controlled access to these fields.
 *
 */
