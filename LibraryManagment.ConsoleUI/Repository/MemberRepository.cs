namespace LibraryManagment.ConsoleUI.Repository;

public class MemberRepository : BaseRepository, IMemberRepository
{
    private List<Member> members;
    
    public MemberRepository()
    {
        members = Members();    
    }
    
    public List<Member> GetAll()
    {
        return members;
    }

    public Member? GetById(string id)
    {
        Member? member = null;

        foreach (Member m in members)
        {
            if (m.Id == id)
            {
                member = m;
            }
        }

        if (member == null)
        {
            return null;
        }
        return member;
    }

    public Member? Add(Member member)
    {
        members.Add(member);
        return member;
    }

    public Member? Update(Member member)
    {
        Member? m = GetById(member.Id);
        
        if (m == null)
        {
            return null;
        }
        
        int index = members.FindIndex(c => c.Id == member.Id);

        if (index != -1) 
        {
            members[index] = member; 
            return member; 
        }

        return null;
    }

    public Member? Remove(string id)
    {
        Member? member = GetById(id);

        if (member == null)
        {
            return null;
        }
        
        members.Remove(member);
        return member;
    }
}














