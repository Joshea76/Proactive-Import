using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmLink
    {
        public int LmlId { get; set; }
        public int LmlCsIdFrom { get; set; }
        public int LmlCsIdTo { get; set; }
        public string LmlRelationship { get; set; }
        public DateTime LmlCreatedDate { get; set; }
        public string LmlCreatedBy { get; set; }
        public bool LmlDeleted { get; set; }
    }
}
