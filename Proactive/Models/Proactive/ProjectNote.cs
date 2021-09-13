using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ProjectNote
    {
        public int ProjectNoteId { get; set; }
        public string Note { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserId { get; set; }
        public int ProjectId { get; set; }
        public DateTime? DoBy { get; set; }
        public bool? Done { get; set; }
        public string Title { get; set; }
        public int? Status { get; set; }
        public int? Priority { get; set; }
        public bool IsNote { get; set; }

        public virtual Project Project { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
