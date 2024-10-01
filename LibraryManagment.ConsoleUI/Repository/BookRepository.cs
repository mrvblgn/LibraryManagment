using LibraryManagment.ConsoleUI.Dtos;

namespace LibraryManagment.ConsoleUI.Repository;

public class BookRepository : BaseRepository, IBookRepository
{
    private List<Book> books;
    private List<Author> authors;
    private List<Category> categories;
    public BookRepository()
    {
        books = Books();
        authors = Authors();
        categories = Categories();
    }
    
    public List<Book> GetAll()
    {
        return books;
    }

    public List<Book> GetAllBooksByPageSizeFilter(int min, int max)
    {
        List<Book> result = books.FindAll(b => b.PageSize <= max && b.PageSize >= min);
        return result;
    }

    public double PageSizeTotalCalculator()
    {
        double total = books.Sum(x => x.PageSize);
        return total;
    }

    public List<Book> GetAllBooksByTitleContains(string text)
    {
        // findAll listelemek için where liste de döndürür dict de
        List<Book> result = books.FindAll(b => b.Title.Contains(text, StringComparison.CurrentCultureIgnoreCase));
        return result;
    }

    public Book? GetBookByISBN(string isbn)
    {
        Book book = books.SingleOrDefault(x => x.ISBN == isbn);
        return book;
    }

    public Book Add(Book created)
    {
        books.Add(created);
        return created;
    }

    public Book? GetById(Guid id)
    {
        Book? book1 = null;
        foreach (Book book in books)
        {
            if (book.Id == id)
            {
                book1 = book;
            }
        }
        if (book1 is null)
        {
            return null;
        }
        return book1;
    }

    public Book? Remove(Guid id)
    {
        Book? deletedBook = GetById(id);

        if (deletedBook is null)
        {
            return null;
        }
        books.Remove(deletedBook);
        return deletedBook;
    }

    public List<Book> GetAllBooksOrderByTitle()
    {
        List<Book> orderedBooks = books.OrderBy(b => b.Title).ToList();
        return orderedBooks;
    }
    
    public List<Book> GetAllBooksOrderByDescendingTitle()
    {
        List<Book> orderedBooks = books.OrderByDescending(b => b.Title).ToList();
        return orderedBooks;
    }

    public Book GetBookMaxPageSize()
    {
        List<Book> orderedBooks = books.OrderByDescending(b => b.PageSize).ToList();
        return orderedBooks[0];
    }
    
    public Book GetBookMinPageSize()
    {
        List<Book> orderedBooks = books.OrderBy(b => b.PageSize).ToList();
        return orderedBooks[0];
    }

    public List<BookDetailDto> GetDetails()
    {
        var result =
            from b in books
            join c in categories
                on b.CategoryId equals c.Id
            select new BookDetailDto(
                Id: b.Id,
                CategoryName: c.Name,
                AuthorName: "",
                Title: b.Title,
                Descrition: b.Descrition,
                PageSize: b.PageSize,
                PublishDate: b.PublishDate,
                ISBN: b.ISBN
                );
        return result.ToList();
    }

    public List<BookDetailDto> GetDetailsV2()
    {
        List<BookDetailDto> details =
            books.Join(categories,
                b => b.CategoryId,
                c => c.Id,
                (book, category) => new BookDetailDto(
                    Id: book.Id,
                    CategoryName: category.Name,
                    AuthorName: "",
                    Title: book.Title,
                    Descrition: book.Descrition,
                    PageSize: book.PageSize,
                    PublishDate: book.PublishDate,
                    ISBN: book.ISBN
                )
            ).ToList();
        
        return details;
    }

    public List<BookDetailDto> GetAllAuthorAndBookDetails()
    {
        var result =
            from b in books
            join c in categories on b.CategoryId equals c.Id
            join a in authors on b.AuthorId equals a.Id

            select new BookDetailDto(
                Id: b.Id,
                Title: b.Title,
                CategoryName: c.Name,
                AuthorName: $"{a.Name} {a.Surname}",
                Descrition: b.Descrition,
                PageSize: b.PageSize,
                PublishDate: b.PublishDate,
                ISBN: b.ISBN
            );
        return result.ToList();
    }

    public List<BookDetailDto> GetAllDetailsByCategoryId(int categoryId)
    {
        var result =
            from b in books
            where b.CategoryId == categoryId
            join c in categories on b.CategoryId equals c.Id
            join a in authors on b.AuthorId equals a.Id
            
            select new BookDetailDto(
                Id: b.Id,
                Title: b.Title,
                CategoryName: c.Name,
                AuthorName: $"{a.Name} {a.Surname}",
                Descrition: b.Descrition,
                PageSize: b.PageSize,
                PublishDate: b.PublishDate,
                ISBN: b.ISBN
            );
        return result.ToList();
    }

    public List<string> GetAllTitles()
    {
        List<string> titles =
            books.Select(t => t.Title).ToList();
        
        return titles;
    }
}































