using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class LmNote
    {
        public int PnId { get; set; }
        public int CsId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Summary { get; set; }
        public Guid? CreatedById { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Guid? UpdatedById { get; set; }
        public bool? IsPhoneNote { get; set; }

        public virtual LmContactSpine Cs { get; set; }
    }
}
