using System;
namespace LessonsUnlimited_V1._2.Services
{
    public interface ILessonServices
    {
        void Create(LessonsUnlimited_V1._2.Models.Lesson lesson);
        void Delete(int id);
        void Edit(LessonsUnlimited_V1._2.Models.Lesson lesson);
        LessonsUnlimited_V1._2.Models.Lesson Find(int id);
        System.Collections.Generic.IList<LessonsUnlimited_V1._2.Models.Lesson> List();
    }
}
