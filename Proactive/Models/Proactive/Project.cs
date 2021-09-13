using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Project
    {
        public Project()
        {
            ProjectNotes = new HashSet<ProjectNote>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDesc { get; set; }
        public string UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public int? ContactId { get; set; }
        public int? OrgId { get; set; }
        public DateTime? CompleteBy { get; set; }
        public bool Finished { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual AspNetUser User { get; set; }
        public virtual ICollection<ProjectNote> ProjectNotes { get; set; }
    }
}
