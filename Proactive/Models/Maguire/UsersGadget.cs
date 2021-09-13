using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class UsersGadget
    {
        public Guid UgdId { get; set; }
        public Guid GadId { get; set; }
        public Guid UsId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Data { get; set; }
        public int Order { get; set; }

        public virtual Gadget Gad { get; set; }
        public virtual User Us { get; set; }
    }
}
