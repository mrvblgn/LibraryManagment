namespace LibraryManagment.ConsoleUI.Repository;

public interface IAuthorRepository : IRepository<Author, int>
{
    List<Author> GetAll();
    Author? GetById(int id);
    Author? Add(Author author);
    Author? Update(Author author);
    Author? Remove(int id);
}