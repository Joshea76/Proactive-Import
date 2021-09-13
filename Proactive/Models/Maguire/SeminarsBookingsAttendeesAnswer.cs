using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class SeminarsBookingsAttendeesAnswer
    {
        public Guid SbaaId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public bool? SbaaDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Guid SqId { get; set; }
        public Guid SembId { get; set; }
        public Guid SembaId { get; set; }
        public string Answer { get; set; }
        public string AnswerExtended { get; set; }
        public int ShortCode { get; set; }
        public string ShortCodePrefix { get; set; }
        public string PrefixedShortCode { get; set; }
    }
}
