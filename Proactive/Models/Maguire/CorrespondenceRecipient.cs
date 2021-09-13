using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class CorrespondenceRecipient
    {
        public Guid CorId { get; set; }
        public Guid CoId { get; set; }
        public string Recipient { get; set; }
        public string RecipientType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Guid? AccId { get; set; }

        public virtual AccountsContact Acc { get; set; }
        public virtual Correspondence Co { get; set; }
    }
}
