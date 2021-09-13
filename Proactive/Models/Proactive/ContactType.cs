using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ContactType
    {
        public ContactType()
        {
            Contacts = new HashSet<Contact>();
        }

        public int ContactTypeId { get; set; }
        public string ContactTypeName { get; set; }
        public string UserId { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
