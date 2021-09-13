using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class VSeminarsQuestion
    {
        public Guid SqId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Guid SemId { get; set; }
        public string Question { get; set; }
        public string QuestionId { get; set; }
        public string GvQuestion { get; set; }
        public string SeminarSummary { get; set; }
        public Guid? SemOwner { get; set; }
        public Guid? SgId { get; set; }
        public string ShortCode { get; set; }
    }
}
