using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Subject
    {
        public Subject()
        {
            Lessons = new HashSet<Lesson>();
            SubjectUsers = new HashSet<SubjectUser>();
        }

        public int SubjectId { get; set; }
        public string SubjectTitle { get; set; }
        public string SubjectDesc { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<SubjectUser> SubjectUsers { get; set; }
    }
}
