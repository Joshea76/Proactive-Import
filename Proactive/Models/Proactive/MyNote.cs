using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class MyNote
    {
        public int MyNoteId { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserId { get; set; }
        public string Tags { get; set; }
        public string Title { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
