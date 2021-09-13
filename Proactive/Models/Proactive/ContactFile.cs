using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Proactive
{
    public partial class ContactFile
    {
        public int ContactFileId { get; set; }
        public int ContactId { get; set; }
        public string UserFileName { get; set; }
        public string FileType { get; set; }
        public int FileSize { get; set; }
        public string PhysicalFileName { get; set; }
        public DateTime DateAdded { get; set; }
        public string UserId { get; set; }
        public string Notes { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
