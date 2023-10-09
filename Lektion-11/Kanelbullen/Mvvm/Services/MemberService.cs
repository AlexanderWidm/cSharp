using Kanelbullen.Mvvm.Models;

namespace Kanelbullen.Mvvm.Services;

public class MemberService
{
    private List<MemberModel> _members;
    public MemberService()
    {
        _members = new List<MemberModel>();
    }
    public void AddMemberToList(MemberModel member)
    {
        _members.Add(member);
    }
    public List<MemberModel> GetMembersFromList()
    {
        return _members;
    }
}
