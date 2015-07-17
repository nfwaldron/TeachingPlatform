using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonsUnlimited.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string LessonTitle { get; set; }
        public string Description { get; set; }

        //I will also need a link to the video lesson.
    }
}