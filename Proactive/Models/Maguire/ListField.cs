using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ListField
    {
        public Guid ListFieldId { get; set; }
        public string ListField1 { get; set; }
        public string DatabaseColumn { get; set; }
        public Guid FieldId { get; set; }
        public string Filter { get; set; }
        public string DisplayFilter { get; set; }
        public int SortBy { get; set; }
        public int Order { get; set; }
        public Guid AreaId { get; set; }
        public Guid PageId { get; set; }
    }
}
