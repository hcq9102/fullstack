namespace Oop6Interfaces.Interfaces;

public interface ICourseService
{
    void AddCourse(string courseName, string courseCode);
    void RemoveCourse(int courseId);
    void EnrollStudent(int courseId, int studentId);
    List<int> GetEnrolledStudents(int courseId);
}

