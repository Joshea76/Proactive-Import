using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class Organisation
    {
        public Organisation()
        {
            AspNetUsers = new HashSet<AspNetUser>();
        }

        public int OrganisationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public int MaxUsers { get; set; }
        public bool IsDisabled { get; set; }

        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
