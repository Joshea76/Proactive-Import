using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class TouchpointLink
    {
        public int TplId { get; set; }
        public Guid ObjId { get; set; }
        public string ObjType { get; set; }
        public int TpId { get; set; }
        public int CsId { get; set; }
        public DateTime Created { get; set; }
        public int TpcId { get; set; }

        public virtual Touchpoint Tp { get; set; }
        public virtual TouchpointConfiguration Tpc { get; set; }
    }
}
