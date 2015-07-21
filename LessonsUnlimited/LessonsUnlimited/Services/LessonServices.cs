using CoderCamps;
using LessonsUnlimited.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonsUnlimited.Services
{
    public class LessonServices : LessonsUnlimited.Services.ILessonServices
    {
        private IGenericRepository _repo;

        // Constructor
        public LessonServices(IGenericRepository repo)
        {
            _repo = repo;
        }

        // Query Database for a list of items
        public IList<Lesson> List()
        {
            return _repo.Query<Lesson>().ToList();
        }

        // Create Find Method
        public Lesson Find(int id)
        {
            return _repo.Find<Lesson>(id);

        }

        // Create Method

        public void Create( Lesson lesson)
        {
            _repo.Add<Lesson>(lesson);
            _repo.SaveChanges();
        }

        public void Edit (Lesson lesson)
        {
            var original = this.Find(lesson.Id);
            original.Author = lesson.Author;
            original.Description = lesson.Description;
            original.LessonTitle = lesson.LessonTitle;
            _repo.SaveChanges();
        }

        public void Delete (int id)
        {
            _repo.Delete<Lesson>(id);
            _repo.SaveChanges();
        }

    }
}