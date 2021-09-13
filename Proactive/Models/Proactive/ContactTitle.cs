using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ContactTitle
    {
        public ContactTitle()
        {
            Contacts = new HashSet<Contact>();
        }

        public int ContactTitleId { get; set; }
        public string TitleDesc { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
