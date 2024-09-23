using LibraryManagment.ConsoleUI.Dtos;
using LibraryManagment.ConsoleUI.Repository;

namespace LibraryManagment.ConsoleUI.Service;

public class BookService
{
    private BookRepository bookRepository = new BookRepository();

    public void GetAll()
    {
        List<Book> books = bookRepository.GetAll();

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void GetById(int id)
    {
        Book? book = bookRepository.GetById(id);
        if (book is null)
        {
            Console.WriteLine($"aradığınız id'ye göre kitap bulunamadı: {id}");
            return;
        }

        Console.WriteLine(book);
    }

    public void Remove(int id)
    {
        Book? deletedBook = bookRepository.Remove(id);
        if (deletedBook is null)
        {
            Console.WriteLine("Aradığınız kitap bulunamadı");
            return;
        }

        Console.WriteLine(deletedBook);
    }

    public void GetBookByISBN(string isbn)
    {
        Book? book = bookRepository.GetBookByISBN(isbn);
        if (book is null)
        {
            Console.WriteLine($"Aradığınız isbn numarasına göre kitap bulunamadı. {isbn}");
            return;
        }

        Console.WriteLine(book);
    }

    public void GetAllBooksByTitleContains(string text)
    {
        List<Book> books = bookRepository.GetAllBooksByTitleContains(text);

        if (books is null)
        {
            Console.WriteLine($"Aradığınız kitap bulunamadı: {text}");
            return;
        }

        foreach (Book item in books)
        {
            Console.WriteLine(item);
        }
    }

    public void GetAllBooksOrderByTitle()
    {
        List<Book> books = bookRepository.GetAllBooksOrderByTitle();

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }
    
    public void GetAllBooksOrderByTitleDescending()
    {
        List<Book> books = bookRepository.GetAllBooksOrderByDescendingTitle();

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void GetBooksMaxPageSize()
    {
        Book book = bookRepository.GetBookMaxPageSize();

        Console.WriteLine(book);
    }
    
    public void GetBooksMinPageSize()
    {
        Book book = bookRepository.GetBookMinPageSize();

        Console.WriteLine(book);
    }

    public void GetDetails()
    {
        List<BookDetailDto> books = bookRepository.GetDetails();

        foreach (BookDetailDto book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void GetDetailsV2()
    {
        List<BookDetailDto> books = bookRepository.GetDetailsV2();
        
        foreach (BookDetailDto book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void GetAllBookAndAuthorDetails()
    {
        List<BookDetailDto> details = bookRepository.GetAllAuthorAndBookDetails();

        details.ForEach(detail => Console.WriteLine(detail));
    }

    public void GetAllDetailsByCategoryId(int categoryId)
    {
        List<BookDetailDto> details = bookRepository.GetAllDetailsByCategoryId(categoryId);
        
        details.ForEach(detail => Console.WriteLine(detail));
    }

    public void Add(Book book)
    {
        BookIdBusinessRules(book.Id);
        BookISBNBusinessRules(book.ISBN);
        
        
        Book created = bookRepository.Add(book);
        Console.WriteLine("Kitap eklendi");
        Console.WriteLine(created);
    }

    private void BookIdBusinessRules(int id)
    {
        Book? getByIdBook = bookRepository.GetById(id);
        if (getByIdBook != null)
        {
            Console.WriteLine($"Girmiş olduğunuz kitabın id alanı benzersiz olmalı: {id}");
            return;
        }
    }

    private void BookISBNBusinessRules(string isbn)
    {
        Book? getByIdBook = bookRepository.GetBookByISBN(isbn);
        if (getByIdBook != null)
        {
            Console.WriteLine($"Girmiş olduğunuz kitabın id alanı benzersiz olmalı: {isbn}");
            return;
        }
        
    }
}












