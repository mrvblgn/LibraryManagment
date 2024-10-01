namespace LibraryManagment.ConsoleUI.Repository;

public interface IRepository<TEntity, TId>
    where TEntity : Entity<TId>, new()
{
    List<TEntity> GetAll();
    public TEntity Add(TEntity created);

    public TEntity? Remove(TId id);

    public TEntity? GetById(TId id);
}