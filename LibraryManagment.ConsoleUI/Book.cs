namespace LibraryManagment.ConsoleUI;

public record Book(
    int Id, 
    string Title,
    string Descrition,
    int PageSize,
    string PublishDate,
    string ISBN);