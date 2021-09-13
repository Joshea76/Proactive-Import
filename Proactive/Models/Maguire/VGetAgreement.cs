using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VGetAgreement
    {
        public Guid AgrId { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte AgreementStatus { get; set; }
        public string AgreementDocumentName { get; set; }
        public string AgreementDocumentFolder { get; set; }
        public string Summary { get; set; }
        public Guid UsId { get; set; }
        public Guid ParentId { get; set; }
        public Guid? DocId { get; set; }
        public string ProviderLink { get; set; }
        public string AgreementName { get; set; }
    }
}
