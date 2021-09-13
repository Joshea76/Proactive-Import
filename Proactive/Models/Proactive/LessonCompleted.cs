using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class LessonCompleted
    {
        public int LessonCompletedId { get; set; }
        public int LessonId { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
