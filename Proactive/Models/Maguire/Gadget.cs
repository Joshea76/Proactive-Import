using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Gadget
    {
        public Gadget()
        {
            UsersGadgets = new HashSet<UsersGadget>();
        }

        public Guid GadId { get; set; }
        public Guid AcoId { get; set; }
        public string Summary { get; set; }
        public string SummaryRef { get; set; }
        public string Type { get; set; }
        public string Data { get; set; }
        public bool? Refresh { get; set; }

        public virtual AccessOption Aco { get; set; }
        public virtual ICollection<UsersGadget> UsersGadgets { get; set; }
    }
}
