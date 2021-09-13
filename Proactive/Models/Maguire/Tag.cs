using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Tag
    {
        public Tag()
        {
            TagsLinks = new HashSet<TagsLink>();
        }

        public int TagId { get; set; }
        public string Tag1 { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Propagate { get; set; }
        public bool Accounts { get; set; }
        public bool Contacts { get; set; }
        public bool Appointments { get; set; }
        public bool Activities { get; set; }
        public bool Opportunities { get; set; }
        public bool Quotes { get; set; }
        public bool Profiles { get; set; }
        public bool Projects { get; set; }
        public bool Campaigns { get; set; }
        public bool Seminars { get; set; }
        public bool Email { get; set; }
        public bool? Notes { get; set; }
        public bool? Products { get; set; }
        public bool? Users { get; set; }
        public string Colour { get; set; }

        public virtual ICollection<TagsLink> TagsLinks { get; set; }
    }
}
