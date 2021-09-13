using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Checklist
    {
        public Checklist()
        {
            ChecklistContacts = new HashSet<ChecklistContact>();
        }

        public int ChecklistId { get; set; }
        public DateTime DateAdded { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DoByDate { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<ChecklistContact> ChecklistContacts { get; set; }
    }
}
