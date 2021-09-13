using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VDropsList
    {
        public Guid DrId { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public string Label { get; set; }
        public Guid? ParentId { get; set; }
        public string ExternalId { get; set; }
        public bool DropOptionsAreScreenDesignable { get; set; }
        public string ObjectName { get; set; }
    }
}
