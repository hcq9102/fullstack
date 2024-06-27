namespace Oop6Interfaces;

// public class ImpleInterface
// {
//
// }

using Oop6Interfaces.Interfaces;


// Implementing class for IPersonService interface
public class PersonService : IPersonService
{
    private DateTime birthDate;
    private decimal salary;
    private List<string> addresses = new List<string>();

    public PersonService(DateTime birthDate, decimal salary)
    {
        this.birthDate = birthDate;
        SetSalary(salary);
    }

    public int CalculateAge()
    {
        var age = DateTime.Now.Year - birthDate.Year;
        if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            age -= 1;
        return age;
    }

    public decimal CalculateSalary()
    {
        return salary;
    }

    public void SetSalary(decimal salary)
    {
        if (salary < 0)
        {
            throw new ArgumentException("Salary cannot be negative.");
        }
        this.salary = salary;
    }

    public void AddAddress(string adr)
    {
        addresses.Add(adr);
    }

    public List<string> GetAddress()
    {
        return addresses;
    }
}

// Implementing class for IStudentService interface
public class StudentService : PersonService, IStudentService
{
    private Dictionary<int, List<char>> courseGrades = new Dictionary<int, List<char>>();

    public StudentService(DateTime birthDate, decimal salary) : base(birthDate, salary) { }

    public void EnrollInCourse(int studentId, int courseId)
    {
        if (!courseGrades.ContainsKey(courseId))
        {
            courseGrades[courseId] = new List<char>();
        }
    }

    public double CalculateGpa(int studentId)
    {
        int totalPoints = 0;
        int totalCourses = 0;

        foreach (var grades in courseGrades.Values)
        {
            foreach (var grade in grades)
            {
                totalPoints += GradeToPoint(grade);
            }
            totalCourses += grades.Count;
        }

        return totalCourses == 0 ? 0 : (double)totalPoints / totalCourses;
    }

    public void AddGrade(int studentId, int courseId, char grade)
    {
        if (courseGrades.ContainsKey(courseId))
        {
            courseGrades[courseId].Add(grade);
        }
        else
        {
            courseGrades[courseId] = new List<char> { grade };
        }
    }

    private int GradeToPoint(char grade)
    {
        switch (grade)
        {
            case 'A': return 4;
            case 'B': return 3;
            case 'C': return 2;
            case 'D': return 1;
            case 'F': return 0;
            default: throw new ArgumentException("Invalid grade.");
        }
    }
}

// Implementing class for IInstructorService interface
public class InstructorService : PersonService, IInstructorService
{
    private DateTime joinDate;
    private int departmentId;
    private bool isHead;

    public InstructorService(DateTime birthDate, decimal salary, DateTime joinDate) : base(birthDate, salary)
    {
        this.joinDate = joinDate;
    }

    public void AssignDepartment(int instructorId, int departmentId)
    {
        this.departmentId = departmentId;
    }

    public void SetAsDepartmentHead(int instructorId, bool isHead)
    {
        this.isHead = isHead;
    }

    public int CalculateYearsOfExperience(DateTime joinDate)
    {
        return DateTime.Now.Year - joinDate.Year;
    }

    public decimal CalculateBonusSalary(decimal baseSalary, int yearsOfExperience)
    {
        return baseSalary + (yearsOfExperience * 1000); // Example bonus calculation
    }
}

// Course class to store course details
public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    public List<int> EnrolledStudents { get; set; } = new List<int>();
}

// Implementing class for ICourseService interface
public class CourseService : ICourseService
{
    private Dictionary<int, Course> courses = new Dictionary<int, Course>();
    private int nextCourseId = 1;

    public void AddCourse(string courseName, string courseCode)
    {
        var course = new Course
        {
            CourseId = nextCourseId++,
            CourseName = courseName,
            CourseCode = courseCode
        };
        courses[course.CourseId] = course;
    }

    public void RemoveCourse(int courseId)
    {
        courses.Remove(courseId);
    }

    public void EnrollStudent(int courseId, int studentId)
    {
        if (courses.ContainsKey(courseId))
        {
            courses[courseId].EnrolledStudents.Add(studentId);
        }
        else
        {
            throw new ArgumentException("Course not found.");
        }
    }

    public List<int> GetEnrolledStudents(int courseId)
    {
        if (courses.ContainsKey(courseId))
        {
            return courses[courseId].EnrolledStudents;
        }
        return new List<int>();
    }
}

// Implementing class for IDepartmentService interface
public class DepartmentService : IDepartmentService
{
    private decimal budget;
    private DateTime startDate;
    private DateTime endDate;
    private int headInstructorId;
    private Dictionary<int, List<int>> departmentCourses = new Dictionary<int, List<int>>();

    public void AddDepartment(string departmentName, decimal budget, DateTime startDate, DateTime endDate)
    {
        this.budget = budget;
        this.startDate = startDate;
        this.endDate = endDate;
        // Add department logic
    }

    public void RemoveDepartment(int departmentId)
    {
        departmentCourses.Remove(departmentId);
    }

    public void SetDepartmentHead(int departmentId, int instructorId)
    {
        this.headInstructorId = instructorId;
    }

    public void SetBudget(decimal amount, DateTime start, DateTime end)
    {
        this.budget = amount;
        this.startDate = start;
        this.endDate = end;
    }

    public decimal GetBudget()
    {
        return budget;
    }

    public void AddCourseToDepartment(int departmentId, int courseId)
    {
        if (!departmentCourses.ContainsKey(departmentId))
        {
            departmentCourses[departmentId] = new List<int>();
        }
        departmentCourses[departmentId].Add(courseId);
    }

    public List<int> GetCoursesOffered(int departmentId)
    {
        if (departmentCourses.ContainsKey(departmentId))
        {
            return departmentCourses[departmentId];
        }
        return new List<int>();
    }
}
