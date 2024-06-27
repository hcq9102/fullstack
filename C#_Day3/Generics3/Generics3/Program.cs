/*
   3. Implement a GenericRepository<T> class that implements IRepository<T> interface
   that will have common /CRUD/ operations so that it can work with any data source
   such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
   on T were it should be of reference type and can be of type Entity which has one
   property called Id. IRepository<T> should have following methods
       1. void Add(T item)
       2. void Remove(T item)
       3. Void Save()
       4. IEnumerable<T> GetAll()
       5. T GetById(int id)
 */

using Generics3;

IRepository<Student> studentRepository = new GenericRepository<Student>();

Student student1 = new Student { Id = 1, Name = "Chuanqiu" };
Student student2 = new Student { Id = 2, Name = "Smith" };

studentRepository.Add(student1);
studentRepository.Add(student2);

Console.WriteLine("Get all students:");
foreach (var student in studentRepository.GetAll())
{
    Console.WriteLine($"StudentID: {student.Id}, Name: {student.Name}");
}

Console.WriteLine("Get student by ID 1:");
var studentById = studentRepository.GetById(1);
Console.WriteLine($"StudentID: {studentById.Id}, Name: {studentById.Name}");

studentRepository.Remove(student1);
studentRepository.Save();  // This will output "Changes have been saved."

Console.WriteLine("Students after removal:");
foreach (var student in studentRepository.GetAll())
{
    Console.WriteLine($"studentID: {student.Id}, Name: {student.Name}");
}

studentRepository.Save();  // "No changes to save."

