using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VItemAction
    {
        public Guid ObjId { get; set; }
        public string Summary { get; set; }
        public string ObjectType { get; set; }
        public Guid? ParentId { get; set; }
        public string ParentType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Body { get; set; }
        public string HtmlBody { get; set; }
        public bool? IsSticky { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? DateReceived { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string SenderAddress { get; set; }
        public string RecipientAddress { get; set; }
        public string FilePath { get; set; }
        public string LinkedItemType { get; set; }
    }
}
