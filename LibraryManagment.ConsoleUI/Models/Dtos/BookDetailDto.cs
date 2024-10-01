namespace LibraryManagment.ConsoleUI.Dtos;

public record BookDetailDto(
    Guid Id,
    string CategoryName,
    string AuthorName,
    string Title,
    string Descrition,
    int PageSize,
    string PublishDate,
    string ISBN);
