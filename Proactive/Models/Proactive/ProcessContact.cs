using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ProcessContact
    {
        public int ProcessProcessId { get; set; }
        public int ContactsContactId { get; set; }

        public virtual Contact ContactsContact { get; set; }
        public virtual Process ProcessProcess { get; set; }
    }
}
