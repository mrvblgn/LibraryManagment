namespace LibraryManagment.ConsoleUI.Repository;

public interface IMemberRepository : IRepository<Member, string>
{
    Member? Add(Member member);
    Member? Update(Member member);
}