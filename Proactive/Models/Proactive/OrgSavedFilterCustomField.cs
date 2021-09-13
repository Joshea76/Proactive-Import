using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class OrgSavedFilterCustomField
    {
        public int Id { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
        public int? SavedFilterId { get; set; }

        public virtual OrgSavedFilter SavedFilter { get; set; }
    }
}
