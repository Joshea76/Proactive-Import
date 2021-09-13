using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class Link
    {
        public Link()
        {
            InversePair = new HashSet<Link>();
        }

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
        public Guid? AcIdFrom { get; set; }
        public Guid? AcIdTo { get; set; }
        public string FromSummary { get; set; }
        public string ToSummary { get; set; }
        public bool? LnkDeleted { get; set; }
        public byte LinkType { get; set; }

        public virtual Link Pair { get; set; }
        public virtual ICollection<Link> InversePair { get; set; }
    }
}
