using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ContactProcessStage
    {
        public int ContactProcessStageId { get; set; }
        public int ProcessId { get; set; }
        public int StageId { get; set; }
        public int ContactId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsCurrent { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
