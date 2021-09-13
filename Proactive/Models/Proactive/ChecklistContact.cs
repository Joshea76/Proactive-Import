using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ChecklistContact
    {
        public int ChecklistId { get; set; }
        public int ContactId { get; set; }
        public bool Done { get; set; }
        public string Note { get; set; }

        public virtual Checklist Checklist { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
