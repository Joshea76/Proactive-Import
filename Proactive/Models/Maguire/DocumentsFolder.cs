using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class DocumentsFolder
    {
        public DocumentsFolder()
        {
            Agreements = new HashSet<Agreement>();
        }

        public Guid DocfId { get; set; }
        public Guid? AcId { get; set; }
        public Guid RefId { get; set; }
        public string Path { get; set; }
        public bool DocfDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool Subfolders { get; set; }

        public virtual ICollection<Agreement> Agreements { get; set; }
    }
}
