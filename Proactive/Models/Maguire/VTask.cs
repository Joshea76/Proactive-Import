using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VTask
    {
        public Guid? AcId { get; set; }
        public Guid? AccId { get; set; }
        public Guid? UsId { get; set; }
        public Guid? RefId { get; set; }
        public string RefTable { get; set; }
        public Guid UstId { get; set; }
        public bool UstDeleted { get; set; }
        public string UstMapiId { get; set; }
        public string UstStoreId { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public string Owner { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DateCompleted { get; set; }
        public decimal? PercentComplete { get; set; }
        public string BillingInformation { get; set; }
        public string Companies { get; set; }
        public string Contacts { get; set; }
        public string Priority { get; set; }
        public bool? Private { get; set; }
        public string Sensitivity { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? Synchronised { get; set; }
        public DateTime? InUpdatedDate { get; set; }
        public DateTime? OutUpdatedDate { get; set; }
        public string OwnerName { get; set; }
    }
}
