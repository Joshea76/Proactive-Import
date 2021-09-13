using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class JobNote
    {
        public int JobNoteId { get; set; }
        public string Note { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DoBy { get; set; }
        public bool? Done { get; set; }
        public string UserId { get; set; }
        public int JobId { get; set; }

        public virtual Job Job { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
