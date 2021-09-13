using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ImportQueue
    {
        public Guid ImId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool? ImDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Summary { get; set; }
        public DateTime StartDate { get; set; }
        public byte[] Spec { get; set; }
        public int TotalRows { get; set; }
        public int ProcessedRows { get; set; }
        public int RowsAdded { get; set; }
        public int RowsUpdated { get; set; }
        public int RowsFailed { get; set; }
        public int Status { get; set; }
        public DateTime? StatusUpdated { get; set; }
    }
}
