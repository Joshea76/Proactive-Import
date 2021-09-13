using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class CallLog
    {
        public Guid CllId { get; set; }
        public Guid UsId { get; set; }
        public Guid AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid ObjId { get; set; }
        public string Type { get; set; }
        public string Number { get; set; }
        public bool Incomming { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? Duration { get; set; }

        public virtual Account Ac { get; set; }
        public virtual AccountsContact Acc { get; set; }
        public virtual User Us { get; set; }
    }
}
