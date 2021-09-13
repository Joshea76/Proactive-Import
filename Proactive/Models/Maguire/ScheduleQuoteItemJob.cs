using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ScheduleQuoteItemJob
    {
        public int Id { get; set; }
        public Guid? Opqdid { get; set; }
        public Guid? OpqId { get; set; }
        public int? Action { get; set; }
        public string Status { get; set; }
        public bool? Completed { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public bool? Deleted { get; set; }
    }
}
