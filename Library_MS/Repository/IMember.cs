using Library_MS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_MS.Repository
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
