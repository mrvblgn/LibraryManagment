namespace LibraryManagment.ConsoleUI;

public record Book(
    int Id, 
    int CategoryId,
    int AuthorId,
    string Title,
    string Descrition,
    int PageSize,
    string PublishDate,
    string ISBN);