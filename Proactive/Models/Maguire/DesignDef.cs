using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DesignDef
    {
        public int DdId { get; set; }
        public Guid DesId { get; set; }
        public Guid TypeId { get; set; }
        public string XmlName { get; set; }
        public bool IsExtension { get; set; }
        public bool IsDefaultDesign { get; set; }
        public bool DdDeleted { get; set; }
        public short DesignType { get; set; }
        public string LabelSingle { get; set; }
        public string LabelPlural { get; set; }
        public int? RelatedDesign { get; set; }
    }
}
