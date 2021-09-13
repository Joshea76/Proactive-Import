using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Lesson
    {
        public int LessonId { get; set; }
        public string LessonTitle { get; set; }
        public int SubjectId { get; set; }
        public string LessonContent { get; set; }
        public int Order { get; set; }
        public string UserId { get; set; }
        public DateTime DateAdded { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
