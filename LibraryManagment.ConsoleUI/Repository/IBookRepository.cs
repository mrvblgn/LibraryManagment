using LibraryManagment.ConsoleUI.Dtos;

namespace LibraryManagment.ConsoleUI.Repository;

public interface IBookRepository : IRepository<Book, Guid>
{
    List<Book> GetAllBooksByPageSizeFilter(int min, int max);

    public double PageSizeTotalCalculator();

    public List<Book> GetAllBooksOrderByTitle();

    public List<Book> GetAllBooksOrderByDescendingTitle();

    public Book GetBookMaxPageSize();

    public Book GetBookMinPageSize();

    public List<BookDetailDto> GetDetails();

    public List<BookDetailDto> GetDetailsV2();

    public List<BookDetailDto> GetAllAuthorAndBookDetails();

    public List<BookDetailDto> GetAllDetailsByCategoryId(int categoryId);

    List<string> GetAllTitles();

}



















