
Repository<Person> personPrepo = new Repository<Person>();
var person = new Person(1, "aa");
var person2 = new Person(2, "Tom");

personPrepo.Add(person);
personPrepo.Add(person2);

Console.WriteLine("Added persons successfully.");


class Repository<T> : IRepository<T> where T : IEntity
{
    private List<T> _entities = new List<T>();

    public void Add(T entity)
    {
        _entities.Add(entity);
    }

    public IEnumerable<T> GetAll()
    {
        return _entities;
    }

    public T GetById(int id)
    {
        return _entities.Find(e => e.Id == id);
    }

    public void Remove(T entity)
    {
        _entities.Remove(entity);
    }
}

interface IRepository<T> where T : IEntity
{
    T GetById(int id);
    IEnumerable<T> GetAll();
    void Add(T entity);
    void Remove(T entity);
}

class Person : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Person(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

interface IEntity
{
    int Id { get; set; }
}
