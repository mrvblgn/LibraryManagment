using LibraryManagment.ConsoleUI.Dtos;

namespace LibraryManagment.ConsoleUI.Repository;


public class BookRepository
{
    List<Author> authors = new List<Author>()
    {
        new Author(1, "Emile", "Zola"),
        new Author(2, "Fyodor", "Dostoyevski"),
        new Author(3, "Recaizade Mahmut", "Ekrem"),
        new Author(4, "Halide Edib", "Adıvar"),
        new Author(5, "Ömer", "Seyfettin"),
        new Author(6, "ALi", "Koç"),
        new Author(7, "Vız vız", "Ali")
    };
    
    List<Book> books = new List<Book>()
    {
        new Book(1, 1, 1, "Germinal", "Kömür Madeni", 341, "2012 Mayıs", "9789750723322"),
        new Book(2, 1, 2, "Suç ve Ceza", "Raskolnikov'un hayatı", 315, "2010 Haziran", "9789750723323"),
        new Book(3, 1, 2, "Kumarbaz", "Bir öğretmenin hayatı", 210, "2009 Ocak", "9789750723323"),
        new Book(4, 1, 3, "Araba Sevdası", "Arabayla alakası olmayan kitap", 400, "1999 Ocak", "9789750723324"),
        new Book(5, 2, 4, "Ateşten Gömlek", "Kurtuluş savaşını anlatan kitap", 320, "2001 Eylül", "9789750723325"),
        new Book(6, 2, 5, "Kaşağı", "Okunmaması gereken bir kitap", 95, "1993 Ocak", "9789750723326"),
        new Book(7, 3, 6, "Harry Potter ve Felsefe Taşı", "Harry felsefe taşını kurtarmaya çalışır", 540, "2000 Ocak", "9789750723327"),
        new Book(8, 3, 6, "16 Yıl Şampiyonluk", "Hayal ürünüdür", 255, "10 Eylül", "9789750723328"),
        new Book(9, 3, 7, "Rezonans Kanunu", "Kişisel gelişim kitabı", 320, "Kasım 2016", "9789750723329")
    };
    
    List<Category> categories = new List<Category>()
    {
        new Category(1, "Dünya Klasikleri"),
        new Category(2, "Türk Klasikleri"),
        new Category(3, "Bilim Kurgu"),
    };

    public List<Book> GetAll()
    {
        return books;
    }

    public List<Book> GetAllBooksByPageSizeFilter(int min, int max)
    {
        // Geleneseksel Yöntem
        /*List<Book> filteredBooks = new List<Book>();

        foreach (Book item in books)
        {
            if (item.PageSize <= max && item.PageSize >= min)
            {
                filteredBooks.Add(item);
            }
        }
        return filteredBooks;*/

        /*
        Linq Geleneksel: 
        List<Book> result = (from b in books
            where b.PageSize <= max && b.PageSize >= min
            select b).ToList();
        return result; */
        
        // List<Book> result = books.Where(b => b.PageSize <= max && b.PageSize >= min).ToList();

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
        /*
        List<Book> filteredBooks = new List<Book>();

        foreach (Book item in books)
        {
            if (item.Title.Contains(text, StringComparison.InvariantCultureIgnoreCase))
            {
                filteredBooks.Add(item);
            }
        }
        return filteredBooks;*/
        
        // findAll listelemek için where liste de döndürür dict de
        List<Book> result = books.FindAll(b => b.Title.Contains(text, StringComparison.CurrentCultureIgnoreCase));
        return result;
    }

    public Book? GetBookByISBN(string isbn)
    {
        /*
        Book? book1 = null;
        foreach (Book item in books)
        {
            if (item.ISBN == isbn)
            {
                book1 = item;
            }
        } */
        // 1.Yöntem
        /*if (book1 is null)
        {
            return null;
        }
        return book1;*/
        
        // 2. Yöntem
        // return book1 ?? book1;
        
        // return book1 == null ? null  : book1;
        
        // Book? book = (from b in books where b.ISBN == isbn select b).FirstOrDefault();
        
        // Book book = books.Where(x => x.ISBN == isbn).SingleOrDefault();

        Book book = books.SingleOrDefault(x => x.ISBN == isbn);
        return book;
    }

    public Book Add(Book created)
    {
        books.Add(created);
        return created;
    }

    public Book? GetById(int id)
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

    public Book? Remove(int id)
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
    
}































