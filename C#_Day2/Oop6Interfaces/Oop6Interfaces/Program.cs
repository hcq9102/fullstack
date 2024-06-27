using Oop6Interfaces;
using Oop6Interfaces.Interfaces;



// Create instances of services
// Create instances of services
IPersonService personService = new PersonService(new DateTime(1990, 1, 1), 50000);
IStudentService studentService = new StudentService(new DateTime(2000, 5, 15), 0);
IInstructorService instructorService = new InstructorService(new DateTime(1980, 8, 25), 70000, new DateTime(2010, 9, 1));
ICourseService courseService = new CourseService();
IDepartmentService departmentService = new DepartmentService();

// Add some addresses to the person
personService.AddAddress("123 Main St");
personService.AddAddress("456 Elm St");

// Calculate age and salary for the person
Console.WriteLine($"Person Age: {personService.CalculateAge()}");
Console.WriteLine($"Person Salary: {personService.CalculateSalary()}");

// Enroll a student in a course
int studentId = 1;
int courseId = 101;
studentService.EnrollInCourse(studentId, courseId);
studentService.AddGrade(studentId, courseId, 'A');

// Calculate GPA for the student
double gpa = studentService.CalculateGpa(studentId);
Console.WriteLine($"Student GPA: {gpa}");

// Assign instructor to a department and set as department head
int instructorId = 1;
int departmentId = 1;
instructorService.AssignDepartment(instructorId, departmentId);
instructorService.SetAsDepartmentHead(instructorId, true);

// Calculate years of experience and bonus salary for the instructor
int yearsOfExperience = instructorService.CalculateYearsOfExperience(new DateTime(2010, 9, 1));
decimal bonusSalary = instructorService.CalculateBonusSalary(instructorService.CalculateSalary(), yearsOfExperience);
Console.WriteLine($"Instructor Years of Experience: {yearsOfExperience}");
Console.WriteLine($"Instructor Bonus Salary: {bonusSalary}");

// Add a course to the course service
courseService.AddCourse("Introduction to Programming", "CS101");

// Enroll a student in the course
courseService.EnrollStudent(courseId, studentId);

// Get enrolled students for a course
List<int> enrolledStudents = courseService.GetEnrolledStudents(courseId);
Console.WriteLine("Enrolled Students in Course CS101:");
foreach (var id in enrolledStudents)
{
    Console.WriteLine($"Student ID: {id}");
}

// Add a department
departmentService.AddDepartment("Computer Science", 1000000, new DateTime(2024, 1, 1), new DateTime(2024, 12, 31));

// Set department head
departmentService.SetDepartmentHead(departmentId, instructorId);

// Add a course to the department
departmentService.AddCourseToDepartment(departmentId, courseId);

// Get courses offered by the department
List<int> departmentCourses = departmentService.GetCoursesOffered(departmentId);
Console.WriteLine("Courses Offered by the Computer Science Department:");
foreach (var id in departmentCourses)
{
    Console.WriteLine($"Course ID: {id}");
}

// Get the department budget
decimal budget = departmentService.GetBudget();
Console.WriteLine($"Department Budget: {budget}");

