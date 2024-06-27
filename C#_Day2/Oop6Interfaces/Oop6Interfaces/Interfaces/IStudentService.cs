namespace Oop6Interfaces.Interfaces;

public interface IStudentService: IPersonService
{
    void EnrollInCourse(int studentId, int courseId);
    double CalculateGpa(int studentId);
    void AddGrade(int studentId, int courseId, char grade);
}
