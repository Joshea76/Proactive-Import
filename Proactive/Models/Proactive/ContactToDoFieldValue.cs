using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ContactToDoFieldValue
    {
        public int ContactId { get; set; }
        public int ContactToDoFieldId { get; set; }
        public string DueDate { get; set; }
        public int ReminderDays { get; set; }
        public string Note { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ContactToDoField ContactToDoField { get; set; }
    }
}
