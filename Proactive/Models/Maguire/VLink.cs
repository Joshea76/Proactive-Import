using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VLink
    {
        public Guid LnkId { get; set; }
        public Guid? PairId { get; set; }
        public Guid RefIdFrom { get; set; }
        public Guid RefIdTo { get; set; }
        public Guid? RelationshipFrom { get; set; }
        public Guid? RelationshipTo { get; set; }
        public string TypeFrom { get; set; }
        public string TypeTo { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool? Autolink { get; set; }
        public string FromSummary { get; set; }
        public string ToSummary { get; set; }
        public Guid? AcIdFrom { get; set; }
        public Guid? AcIdTo { get; set; }
        public string RelationshipFromLabel { get; set; }
        public string RelationshipToLabel { get; set; }
        public string RelationshipFromLabelHlight { get; set; }
        public string RelationshipToLabelHlight { get; set; }
        public string TypeToLabel { get; set; }
        public string DeleteText { get; set; }
        public string AcNameFrom { get; set; }
        public string AcNameTo { get; set; }
        public Guid? UsIdSalesFrom { get; set; }
        public Guid? UsIdSalesTo { get; set; }
        public Guid? UsIdSupportFrom { get; set; }
        public Guid? UsIdSupportTo { get; set; }
        public string AcGroupFrom { get; set; }
        public string AcGroupTo { get; set; }
        public Guid AcoIdTo { get; set; }
        public string RelationshipFromDetails { get; set; }
        public string RelationshipToDetails { get; set; }
    }
}
