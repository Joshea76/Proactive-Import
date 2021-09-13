using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class QuickNote
    {
        public int QuickNoteId { get; set; }
        public string Note { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Done { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
