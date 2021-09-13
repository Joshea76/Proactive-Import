using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VEventbriteIntegratedEvent
    {
        public Guid EiId { get; set; }
        public bool EiDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public Guid? SemId { get; set; }
        public short? EiStatus { get; set; }
        public string EventId { get; set; }
        public string EventName { get; set; }
        public string Url { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Changed { get; set; }
        public int? Capacity { get; set; }
        public string Status { get; set; }
        public string Currency { get; set; }
        public bool? OnlineEvent { get; set; }
        public string Organiser { get; set; }
        public string Format { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public bool? Listed { get; set; }
        public bool? InviteOnly { get; set; }
        public string Timezone { get; set; }
        public string Seminar { get; set; }
        public string EiStatusTranslated { get; set; }
        public string Gvobject { get; set; }
    }
}
