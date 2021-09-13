using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class AccessOption
    {
        public AccessOption()
        {
            DesignLegacyActions = new HashSet<DesignLegacyAction>();
            Gadgets = new HashSet<Gadget>();
            UsersGroupsOptions = new HashSet<UsersGroupsOption>();
        }

        public Guid AcoId { get; set; }
        public string Summary { get; set; }
        public string SingularLabel { get; set; }
        public string PluralLabel { get; set; }
        public Guid? LicenceType { get; set; }
        public bool IsAdminOption { get; set; }

        public virtual ICollection<DesignLegacyAction> DesignLegacyActions { get; set; }
        public virtual ICollection<Gadget> Gadgets { get; set; }
        public virtual ICollection<UsersGroupsOption> UsersGroupsOptions { get; set; }
    }
}
