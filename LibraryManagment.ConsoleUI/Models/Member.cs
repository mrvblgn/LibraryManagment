namespace LibraryManagment.ConsoleUI;

public class Member : Entity<string>
{
    public Member()
    {
    }

    public Member(string id, string name, string surname, int age) : base(id)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}