var students = new List<Student>
{
    new Student {Id =1, Name="AA", Age=33},
    new Student {Id=2,Name="BB",Age=22}
};

StudnetManagement manage = new StudnetManagement(students);
manage.AddStudnet(new Student { Id = 3, Name = "ee", Age = 11 });
manage.AddStudnet(new Student { Id = 4, Name = "ese", Age = 141 });
manage.RemoveStudnet(2);

foreach (var student in manage.GetAllStudents())
{
    Console.WriteLine($"id {student.Id} Name {student.Name} Age {student.Age}");
}
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Age { get; set; }
}

public class StudnetManagement
{

    private List<Student> _students;

    public StudnetManagement(List<Student> students)
    {
        _students = students;
    }
    public List<Student> GetAllStudents()
    {
        return _students;
    }
    public void AddStudnet(Student student)
    {
        _students.Add(student);
    }

    public void RemoveStudnet(int id)
    {
        var studentRemove = _students.Find(x => x.Id == id);
        if (studentRemove != null) {_students.Remove(studentRemove);}
    }
}