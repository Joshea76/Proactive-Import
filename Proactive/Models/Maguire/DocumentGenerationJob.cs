using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DocumentGenerationJob
    {
        public DocumentGenerationJob()
        {
            DocumentGenerationJobItems = new HashSet<DocumentGenerationJobItem>();
        }

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string TemplateName { get; set; }
        public byte FileOutput { get; set; }
        public byte DocumentFormat { get; set; }
        public byte FileAction { get; set; }
        public byte JobStatus { get; set; }
        public string DocumentFileName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string MergedFilePath { get; set; }
        public Guid? SaveFolderId { get; set; }

        public virtual ICollection<DocumentGenerationJobItem> DocumentGenerationJobItems { get; set; }
    }
}
