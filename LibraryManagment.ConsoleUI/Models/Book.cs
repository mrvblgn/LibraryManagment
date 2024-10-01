namespace LibraryManagment.ConsoleUI;

public sealed class Book : Entity<Guid>
{
    public Book(){}
    
    // ctorp 
    public Book(Guid id, int categoryId, int authorId, string title, string descrition, int pageSize, string publishDate, string isbn) : base(id)
    {
        CategoryId = categoryId;
        AuthorId = authorId;
        Title = title;
        Descrition = descrition;
        PageSize = pageSize;
        PublishDate = publishDate;
        ISBN = isbn;
    }
    public int CategoryId { get; set; }
    public int AuthorId { get; set; }
    public string Title { get; set; }
    public string Descrition { get; set; }
    public int PageSize { get; set; }
    public string PublishDate { get; set; }
    public string ISBN { get; set; }
}