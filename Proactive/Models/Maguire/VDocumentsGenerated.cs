using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VDocumentsGenerated
    {
        public string Template { get; set; }
        public byte FileOutput { get; set; }
        public byte DocumentFormat { get; set; }
        public byte FileAction { get; set; }
        public byte JobStatus { get; set; }
        public string Summary { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string MergedFilePath { get; set; }
        public Guid? SaveFolderId { get; set; }
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public Guid ParentId { get; set; }
        public Guid DesignId { get; set; }
        public string ErrorMessage { get; set; }
        public string ParentType { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public string ParentSummary { get; set; }
    }
}
