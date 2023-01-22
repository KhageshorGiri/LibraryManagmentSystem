using Library_MS.Models;
using System.Collections.Generic;

namespace Library_MS.Interfaces
{
    public interface IMember
    {
        IEnumerable<Member> GetAllMembers();

        Member GetMembers(int Id);

        void CreateMember(Member member, Address address);

        void UpdateMember(Member member);

        void DeleteMember(Member member);
    }
}
