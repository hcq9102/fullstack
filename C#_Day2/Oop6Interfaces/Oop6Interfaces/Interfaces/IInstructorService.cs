namespace Oop6Interfaces.Interfaces;

public interface IInstructorService:IPersonService
{
    void AssignDepartment(int instructorId, int departmentId);
    void SetAsDepartmentHead(int instructorId, bool isHead);
    int CalculateYearsOfExperience(DateTime joinDate);
    decimal CalculateBonusSalary(decimal baseSalary, int yearsOfExperience);

}
