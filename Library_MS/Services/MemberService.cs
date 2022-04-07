using Library_MS.Models;
using Library_MS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_MS.Model_DBContext;
using Microsoft.EntityFrameworkCore;

namespace Library_MS.Services
{
    public class MemberService : IMember
    {
        private LibraryContext db;

        public MemberService(LibraryContext context)
        {
            this.db = context;
        }
       
        public void CreateMember(Member member, Address address)
        {

            member.Addresses.Add(new Address()
            {
                Country = address.Country,
                City = address.City,
                AdditionalInfo = address.AdditionalInfo
            });
            db.Members.Add(member);
            db.SaveChanges();

            //another simple approach for this is 
            // db.Members.Add(member); db.saveChanges();
            //int memberId = member.MemberID;

            //address.MemberID = memberId;
            // db.Addresses.Add(address); db.saveChanges();

        }

        public void DeleteMember(Member member)
        {
            db.Members.Remove(member);
            db.SaveChanges();
        }

        public IEnumerable<Member> GetAllMembers()
        {
            return db.Members.Include(p=>p.Addresses).ToList();
        }

        public Member GetMembers(int Id)
        {
            Member member = db.Members.Include(p => p.Addresses).SingleOrDefault(p=>p.MemberID == Id);
            return member;
            
        }

        public void UpdateMember(Member member)
        {
            db.Entry(member).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
