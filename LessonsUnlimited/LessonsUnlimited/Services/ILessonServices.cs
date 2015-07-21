using System;
namespace LessonsUnlimited.Services
{
    public interface ILessonServices
    {
        void Create(LessonsUnlimited.Models.Lesson lesson);
        void Delete(int id);
        void Edit(LessonsUnlimited.Models.Lesson lesson);
        LessonsUnlimited.Models.Lesson Find(int id);
        System.Collections.Generic.IList<LessonsUnlimited.Models.Lesson> List();
    }
}
