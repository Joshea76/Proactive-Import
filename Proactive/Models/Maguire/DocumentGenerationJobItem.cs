using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DocumentGenerationJobItem
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public Guid ItemId { get; set; }
        public Guid DesignId { get; set; }
        public string ErrorMessage { get; set; }
        public byte ItemStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string DocumentJobItemReferenceId { get; set; }
        public int? ItemOrder { get; set; }

        public virtual DocumentGenerationJob Job { get; set; }
    }
}
