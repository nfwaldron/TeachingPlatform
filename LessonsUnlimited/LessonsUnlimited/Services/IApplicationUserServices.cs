using System;
namespace LessonsUnlimited.Services
{
    public interface IApplicationUserServices
    {
        void Create(LessonsUnlimited.Models.ApplicationUser member);
        void Delete(int id);
        void Edit(LessonsUnlimited.Models.ApplicationUser member);
        LessonsUnlimited.Models.ApplicationUser Find(int id);
        System.Collections.Generic.IList<LessonsUnlimited.Models.ApplicationUser> List();
    }
}
