using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LessonsUnlimited_V1._2.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoLink { get; set; }
    }
}