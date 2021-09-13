using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VLinksDocsNote
    {
        public string ObjId { get; set; }
        public string ActionId { get; set; }
        public string Summary { get; set; }
        public string ObjectType { get; set; }
        public string ObjectLabel { get; set; }
        public Guid? ParentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UsEmail { get; set; }
    }
}
