var students = new List<Student>
{
    new Student {Id =1, Name="AA", Age=33},
    new Student {Id=2,Name="BB",Age=22}
};

StudnetManagement manage = new StudnetManagement(students);

foreach (var student in manage.GetAllStudents())
{
    Console.WriteLine($"id {student.Id} Name {student.Name} Age {student.Age}");
}
public  class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Age { get; set; }
}

public class StudnetManagement
{

    private IEnumerable<Student> _students;

    public StudnetManagement(IEnumerable<Student> students)
    {
        _students = students;
    }
    public IEnumerable<Student> GetAllStudents()
    {
        return _students;
    }
    public void AddStudnet(Student student)
    {
        throw new NotImplementedException("Can not add");
    }
}