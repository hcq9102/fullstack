namespace Generics3;

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private readonly List<T> queries;
    private bool isModified;

    public GenericRepository()
    {
        queries = new List<T>();
    }

    public void Add(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        queries.Add(item);
    }

    public void Remove(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        queries.Remove(item);
    }

    public void Save()
    {
        if (isModified)
        {
            // it may persist the data to the data source
            // such as a database. Here it doesn't do anything as we are working with an in-memory list.
            isModified = false;
            Console.WriteLine("Changes have been saved.");
        }
        else
        {
            Console.WriteLine("No changes to save.");
        }
    }

    public IEnumerable<T> GetAll()
    {
        return queries;
    }

    public T GetById(int id)
    {
        return queries.SingleOrDefault(e => e.Id == id);
    }
}


// instance class

public class Student : Entity
{
    public string Name { get; set; }
}
