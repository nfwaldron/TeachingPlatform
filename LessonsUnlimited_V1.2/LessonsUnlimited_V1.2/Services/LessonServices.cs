 using CoderCamps;
using LessonsUnlimited_V1._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonsUnlimited_V1._2.Services
{
    public class LessonServices : LessonsUnlimited_V1._2.Services.ILessonServices
    {
        //Creating a constant string used to represent key in dictionary for looking up 'Animal' entities
        const string LESSONS_CACHE_KEY = "LESSONS_CACHE_KEY";
        
        private IGenericRepository _repo;
        
        public LessonServices(IGenericRepository repo)
        {
            _repo = repo;
        }

        // Query Database for a list of the entities stored therein.
        // Implement caching to improve performance.
        // Caching is a component that stored data so that the data can be accessed
        // Much quicker in the future.

        public IList<Lesson> List () 
        {
            // Attempt to retrieve a list of lessons from the cache
            var lessons = HttpRuntime.Cache[LESSONS_CACHE_KEY];

            // If the cache 'lessons' is empty, add the list to the cache.
            if (lessons == null )
            {
                // Retrieve the 'Lessons' entity from the database and return it as a list.
                lessons = _repo.Query<Lesson>().ToList();
                // Add the 'Lesson' entities stored in the 'lesson' variable to the cache
                HttpRuntime.Cache[LESSONS_CACHE_KEY] = lessons;
            }
            
            // We have to case the result as a IList<Lesson> because the Cache object is weakly typed
            // The cache object is a weakly typed dictionary that returns back objects. In order to 
            // fulfill the requirements of this method, we cast lessons asn a IList of Lesson(s).
            return lessons as IList<Lesson>;

        }

        public Lesson Find(int id)
        {
            return _repo.Find<Lesson>(id);
        }

        public void Create (Lesson lesson)
        {
            
            _repo.Add<Lesson>(lesson);
            _repo.SaveChanges();
            HttpRuntime.Cache.Remove(LESSONS_CACHE_KEY);
        }

        public void Edit(Lesson lesson)
        {
            
            
            var original = this.Find(lesson.Id);
            original.Author = lesson.Author;
            original.Title = lesson.Title;
            original.Description = lesson.Description;
            _repo.SaveChanges();
            HttpRuntime.Cache.Remove(LESSONS_CACHE_KEY);
        }

        public void Delete (int id)
        {
            _repo.Delete<Lesson>(id);
            _repo.SaveChanges();
            HttpRuntime.Cache.Remove(LESSONS_CACHE_KEY);
        }

    }
}