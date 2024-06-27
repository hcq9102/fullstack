namespace Oop6Interfaces.Interfaces;

public interface IDepartmentService
{
    void AddDepartment(string departmentName, decimal budget, DateTime startDate, DateTime endDate);
    void RemoveDepartment(int departmentId);
    void SetDepartmentHead(int departmentId, int instructorId);
    void SetBudget(decimal amount, DateTime start, DateTime end);
    decimal GetBudget();
    void AddCourseToDepartment(int departmentId, int courseId);
    List<int> GetCoursesOffered(int departmentId);
}
