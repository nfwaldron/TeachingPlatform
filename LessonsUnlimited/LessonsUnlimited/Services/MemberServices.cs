using CoderCamps;
using LessonsUnlimited.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonsUnlimited.Services
{
    public class MemberServices : LessonsUnlimited.Services.IMemberServices
    {
        public IGenericRepository _repo;

        public MemberServices(IGenericRepository repo)
        {
            _repo = repo;
        }

        // Querying the Database
        public IList<Member> List()
        {
            return _repo.Query<Member>().ToList();
        }

        // Find Member
        public Member Find(int id)
        {
            return _repo.Find<Member>(id);
        }

        // Create Member
        public void Create(Member member)
        {
            _repo.Add<Member>(member);
            _repo.SaveChanges();
        }

        public void Edit(Member member)
        {
            var original = this.Find(member.Id);
            original.Email = member.Email;
            original.FirstName = member.FirstName;
            original.LastName = member.LastName;
            original.Password = member.Password;
            _repo.SaveChanges();
        }

        public void Delete(int id)
        {
            _repo.Delete<Member>(id);
            _repo.SaveChanges();
        }

    }
}