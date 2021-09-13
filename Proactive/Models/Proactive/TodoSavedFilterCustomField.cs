using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class TodoSavedFilterCustomField
    {
        public int Id { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
        public int? SavedFilterId { get; set; }

        public virtual TodoSavedFilter SavedFilter { get; set; }
    }
}
