using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class GvvLegacyInfoForDesign
    {
        public Guid DesignId { get; set; }
        public string ShortCodePrefix { get; set; }
        public Guid LegId { get; set; }
        public string XmlFilename { get; set; }
        public short LegacyType { get; set; }
        public Guid? ListObjectRef { get; set; }
        public bool IsExtension { get; set; }
        public bool IsAdmin { get; set; }
        public bool? IsLeadObject { get; set; }
        public string GlobalSearchFunction { get; set; }
        public string GlobalSearchPrimaryKeyColumn { get; set; }
        public string GlobalSearchSubDataColumn { get; set; }
        public string GlobalSearchPrimaryKeyLabelColumn { get; set; }
        public string PrimaryKeyColumn { get; set; }
        public string ItemFieldLabelColumn { get; set; }
        public string ListObjectFilename { get; set; }
    }
}
