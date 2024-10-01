namespace LibraryManagment.ConsoleUI;

public sealed class Category : Entity<int>
{
    public Category(){}

    public Category(int id, string name) : base(id)
    {
        Id = id;
        Name = name;
    }
    
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }
}