using System;
namespace LessonsUnlimited.Services
{
    public interface IMemberServices
    {
        void Create(LessonsUnlimited.Models.Member member);
        void Delete(int id);
        void Edit(LessonsUnlimited.Models.Member member);
        LessonsUnlimited.Models.Member Find(int id);
        System.Collections.Generic.IList<LessonsUnlimited.Models.Member> List();
    }
}
